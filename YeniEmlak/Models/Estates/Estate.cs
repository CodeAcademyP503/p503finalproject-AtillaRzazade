using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YeniEmlak.Models.Estates;

namespace YeniEmlak.Models
{
    public class Estate
    {
        public int Id { get; set; }
        public EstateType EstateType { get; set; }
        public City City { get; set; }
        public string Address { get; set; }
        public decimal Price { get; set; }
        public uint Area { get; set; }



    }

}
