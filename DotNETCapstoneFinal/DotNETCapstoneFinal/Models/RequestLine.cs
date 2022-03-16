using DotNETCapstoneFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DotNETCapstoneFinal
{
    public class RequestLine
    {

        public int Id { get; set; }
        public static int NextId { get; set; }

        public int RequestId { get; set; }
        [JsonIgnore]
        public virtual Request Request { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int Quantity { get; set; } = 1;

        public RequestLine() {
            Id = ++NextId;
        }
    }
}