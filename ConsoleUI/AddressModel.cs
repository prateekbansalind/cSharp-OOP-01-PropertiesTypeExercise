using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class AddressModel
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }

        private string _address;

        public string Address
        {
            get { return $"{Street}, {City}, {Region}, {Country}, {ZipCode}"; }
           
        }

    }
}
