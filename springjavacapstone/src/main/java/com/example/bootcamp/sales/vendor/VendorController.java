package com.example.bootcamp.sales.vendor;

import javax.persistence.EntityManager;
import javax.persistence.TypedQuery;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.example.bootcamp.sales.product.ProductRepository;

@CrossOrigin
@RestController
@RequestMapping("api/vendors")
public class VendorController {

	@Autowired
	private VendorRepository vendorRepo;
//	@Autowired
//	private ProductRepository productRepo;
//	
//	@GetMapping("po/{id}")
//	public ResponseEntity<PO> CreatePo(@PathVariable int id){
//		var v1 = vendorRepo.findById(id);
//		var p1 = productRepo.findById //Think about linking them all together throuhg repos????
		
		
//		TypedQuery<PO> query = EntityManager.createQuery(
//				"SELECT * FROM vendor v JOIN prodct p ON v.id=p.vendorId", vendorRepo.getClass());
//		List<PO> resultList= query.getResultList();
				
//				
//				""
//				+ "SELECT * FROM vendor as v "
//				+ "LEFT JOIN product as p ON v.id=p.=vendorId "
//				+ "LEFT JOIN requetline as rl ON p.id = rl.productId"
//				+ "LEFT JOIN request as r ON rl.requestId = r.id"
//				+ "WHERE r.status = 'APPROVED'"
//				 {
//					var id = product.getId(),
//					var product = product.getName(),
//					var quantity = requestline.getQuantity(),
//					var price = product.getPrice(),
//					var lineTotal = price * quantity
//				 }
//				);
//		
		
//	}
	
	@GetMapping
	public ResponseEntity<Iterable<Vendor>> GetVendor(){
		var vendors =vendorRepo.findAll();
		return new ResponseEntity<Iterable<Vendor>>(vendors, HttpStatus.OK);
	}
	
	@GetMapping("{id}")
	public ResponseEntity<Vendor> GetVendorById(@PathVariable int id){
	var vendor = vendorRepo.findById(id);
	if(vendor.isEmpty()) {
		return new ResponseEntity<>(HttpStatus.NOT_FOUND);
	}
		return new ResponseEntity<Vendor>(vendor.get(),HttpStatus.OK);
	}
	
	@PostMapping
	public ResponseEntity<Vendor> PostVendor(@RequestBody Vendor vendor){
		if (vendor == null || vendor.getId() != 0){
			return new ResponseEntity<>(HttpStatus.BAD_REQUEST);
		}
		var v1 = vendorRepo.save(vendor);
		return new ResponseEntity<Vendor>(v1,HttpStatus.CREATED);
	}
	
	@PutMapping("{id}")
	public ResponseEntity<Vendor> PutVendor(@RequestBody Vendor vendor, @PathVariable int id){
		if(vendor == null || vendor.getId()==0) {
			return new ResponseEntity<>(HttpStatus.BAD_REQUEST);
		}
		var v1 = vendorRepo.findById(id);
		if(v1.isEmpty()) {
			return new ResponseEntity<>(HttpStatus.NOT_FOUND);
		}
		vendorRepo.save(vendor);
		return new ResponseEntity<>(HttpStatus.NO_CONTENT);
	}
	@DeleteMapping("{id}")
	public ResponseEntity<Vendor> DeleteVendoro(@PathVariable int id){
		var vendor = vendorRepo.findById(id);
	if(vendor.isEmpty()) {
		return new ResponseEntity<>(HttpStatus.NOT_FOUND);
	}
	vendorRepo.delete(vendor.get());
	return new ResponseEntity<>(HttpStatus.NO_CONTENT);
	
	}
	
}
