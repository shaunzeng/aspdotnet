using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoppingStore.ui.Entities
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get {
                return FirstName + " " + LastName;
            }
        }
        public Address Location { get; set; }
    }
}