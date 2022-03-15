using System.ComponentModel.DataAnnotations.Schema;

namespace DotNETcapstone.Models
{
    public class RequestLine
    {

        public int Id { get; set; }
        private static int NextId { get; set; }

       
        public virtual int RequestId { get; set; }
        [ForeignKey("RequestId")]
        public virtual Request Request { get; set; }

        public virtual int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        public int Quantity { get; set; }

        public RequestLine() {
            Id = ++NextId;
        }

    }
}
