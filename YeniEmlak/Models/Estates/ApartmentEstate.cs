using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YeniEmlak.Models.Estates
{
    public class ApartmentEstate:ApartmentTypeEstate,IApartmentTypeEstate,IArrayInitializer
    {
        public ApartmentEstate()
        {
            EstateType = EstateType.Bina_ev_mənzil;
            
        }

        public bool NewlyBuilt { get; set; }
    }
}
