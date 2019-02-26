using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YeniEmlak.Models.Estates
{
    public interface IApartmentTypeEstate
    {
        uint RoomCount { get; set; }
        uint LocatedStorey { get; set; }
        object[] Stories { get; set; }
        object[] AdditionalFeatures { get; set; }
    }
}
