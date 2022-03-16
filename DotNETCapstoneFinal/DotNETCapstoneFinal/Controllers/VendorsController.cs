using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DotNETCapstoneFinal.Models;

namespace DotNETCapstoneFinal.Controllers
{
    public class VendorsController : Controller
    {
        private readonly AppDbContext _context;

        public VendorsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("purchaseOrder/{vendorId}")]
        public async Task<ActionResult<PurchaseOrder>> CreatePurchaseOrder(int vendorId)
        {
            var vendor = await _context.Vendors.FindAsync(vendorId);

            var query = (from v in _context.Vendors
                       join p in _context.Products
                       on v.Id equals p.VendorId
                       join rl in _context.RequestLines
                       on p.Id equals rl.ProductId
                       join r in _context.Requests
                       on rl.RequestId equals r.Id
                       where r.Status == "APPROVED"
                       && v.Id == vendorId
                       select new
                       {
                           p.Id,
                           Product = p.Name,
                           rl.Quantity,
                           p.Price,
                           LineTotal = p.Price * rl.Quantity
                       });

            var sortedLines = new SortedList<int, PurchaseOrderLine>();
            foreach (var q in query)
            {
                if (!sortedLines.ContainsKey(q.Id))
                {
                    var purchaseOrderLine = new PurchaseOrderLine()
                    {
                        Product = q.Product,
                        Quantity = 0,
                        Price = (decimal)q.Price,
                        LineTotal = (decimal)q.LineTotal
                    };
                    sortedLines.Add(q.Id, purchaseOrderLine);
                }
                sortedLines[q.Id].Quantity += q.Quantity;
                sortedLines[q.Id].LineTotal = sortedLines[q.Id].Quantity * sortedLines[q.Id].Price;
            }



            var sumOfLines = sortedLines.Values.Sum(x => x.LineTotal);

            var returnThis = new PurchaseOrder()
            {
                Vendor = vendor,
                PurchaseOrderLines = (IEnumerable<PurchaseOrderLine>)sortedLines,
                PoTotal = sumOfLines
            };
            return returnThis;
        }





        // GET: Vendors
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vendor.ToListAsync());
        }

        // GET: Vendors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendor = await _context.Vendor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vendor == null)
            {
                return NotFound();
            }

            return View(vendor);
        }

        // GET: Vendors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vendors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Code,Name,Address,City,State,Zip,Phone,Email")] Vendor vendor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vendor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vendor);
        }

        // GET: Vendors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendor = await _context.Vendor.FindAsync(id);
            if (vendor == null)
            {
                return NotFound();
            }
            return View(vendor);
        }

        // POST: Vendors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Code,Name,Address,City,State,Zip,Phone,Email")] Vendor vendor)
        {
            if (id != vendor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendorExists(vendor.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(vendor);
        }

        // GET: Vendors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendor = await _context.Vendor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vendor == null)
            {
                return NotFound();
            }

            return View(vendor);
        }

        // POST: Vendors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vendor = await _context.Vendor.FindAsync(id);
            _context.Vendor.Remove(vendor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendorExists(int id)
        {
            return _context.Vendor.Any(e => e.Id == id);
        }
    }
}
