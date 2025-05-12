using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dani.C_
{
    internal class Address
    {
        private int IdAddress {  get; set; }
        private string Name { get; set; }
        private string Number { get; set; }

        public Address(int idAddress, string name, string number)
        {
            IdAddress = idAddress;
            Name = name;
            Number = number;
        }

        public override string ToString()
        {
            return $"{Name}, N°: {Number}";
        }

     
    }
}
