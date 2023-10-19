using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    // public string streetName { get { return set; } set; }
    
    internal class PostalAddress
    {
        public string streetName { get; private set; }
        public int houseNumber { get; private set; }
        public int ApartmentNumber { get; private set; }
        public int postCode { get; private set; }
        public string city { get; private set; }
        public string country { get; private set; }

        public string FullAddress 
        {
            get
            {
                string address = $"{houseNumber}/{ApartmentNumber} {streetName}\n{city}\n{postCode}\n{country}";
                return address ;
            }
        }


    }
}
