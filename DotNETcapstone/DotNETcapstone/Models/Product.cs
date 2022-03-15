using Castle.MicroKernel.SubSystems.Conversion;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNETcapstone.Models
{
    public class Product
    {
        public int Id { get; set; }
        private static int NextId { get; set; }
        [Required, StringLength(30)]
        public string PartNbr { get; set; }
        [Required, StringLength(30)]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "decimal(9,2)")]
        public double Price { get; set; }
        [Required, StringLength(30)]


        public string Unit { get; set; }
        [Required, StringLength(255)]
        public string PhotoPath { get; set; }
      
        public virtual int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public Product()
        {
            Id = ++NextId;
        }
    }
}
