using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YeniEmlak.Models
{
    public class Advertisement
    {
        public int Id { get; set; }
        public AdvertisementType AdvertisementType { get; set; }
        public Estate Estate { get; set; }
    }
}
