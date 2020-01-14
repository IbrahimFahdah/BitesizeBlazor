using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ChainedBinds
{
    public class DataObject
    {
        public static DataObject Instance = new DataObject();
        public DateTime? Date { get; set; } = DateTime.ParseExact("14/01/2020","dd/MM/yyyy" , CultureInfo.InvariantCulture);
    }
}
