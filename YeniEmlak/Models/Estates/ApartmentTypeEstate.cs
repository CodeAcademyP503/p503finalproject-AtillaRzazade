using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YeniEmlak.Models.Estates
{
    public class ApartmentTypeEstate : Estate, IApartmentTypeEstate, IArrayInitializer
    {
        public uint RoomCount { get; set; }
        public uint LocatedStorey { get; set; }
        public object[] Stories { get; set; }
        public object[] AdditionalFeatures { get; set; }

        public object[] Initializer(object[] array, params object[] objects)
        {
            int count = -1;
            foreach (object item in objects)
            {
                count++;
                array.SetValue(item, count);
            }
            return array;
        }
    }
}
