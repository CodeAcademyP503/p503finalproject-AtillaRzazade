using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YeniEmlak.Models.Estates
{
    public interface IArrayInitializer
    {
        object[] Initializer(object[] array,params object[] objects);
    }
}
