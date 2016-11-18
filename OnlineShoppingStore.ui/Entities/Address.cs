using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoppingStore.ui.Entities
{
    public class Address
    {
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int ZipCode { get; set; }
        public Address (string street,
                        string street2,
                        string city,
                        string state,
                        string country,
                        int zip)
        {
            Street = street;
            Street2 = street2;
            City = city;
            State = state;
            Country = country;
            ZipCode = zip;
        }
    }
}