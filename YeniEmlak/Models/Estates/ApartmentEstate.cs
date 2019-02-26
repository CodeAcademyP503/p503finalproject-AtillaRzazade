<<<<<<< HEAD
﻿using System;
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
=======
﻿using System;
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
>>>>>>> a6338ffe060c15c90e0a149ba25fa79f0ffbe7b8
