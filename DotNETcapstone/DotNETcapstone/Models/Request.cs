using Castle.MicroKernel.SubSystems.Conversion;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNETcapstone.Models
{
    public class Request
    {
        public int Id { get; set; }
        private static int NextId { get; set; }
        [Required, StringLength(80)]
        public string Description { get; set; }
        [Required, StringLength(80)]
        public string Justification { get; set; }
        
        [Required, StringLength(80)]
        public string RejectionReason { get; set; }
        [Required, StringLength(10)]
        public string Status { get; set; } = "NEW";
        [Required]
        [Column(TypeName = "decimal(9,2)")]
        public double Total { get; set; }

        public virtual int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public virtual IEnumerable<RequestLine> RequestLines { get; set; }
        
        public Request()
        {
            Id = ++NextId;
        }
    }
}
