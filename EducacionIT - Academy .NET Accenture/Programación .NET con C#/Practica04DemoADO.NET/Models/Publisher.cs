using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADO.NET.Models
{
    public class Publisher
    {
        public Publisher() { }
        public Publisher(string id, string name, string city, string state, string country) {
            Pub_id = id;
            Pub_name = name;
            City = city;
            State = state;
            Country = country;
        }


        public string Pub_id { get; set; }
        public string Pub_name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
