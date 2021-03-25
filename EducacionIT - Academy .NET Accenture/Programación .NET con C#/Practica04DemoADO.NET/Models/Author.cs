using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADO.NET.Models
{
    public class Author
    {
        public Author()
        {
        }

        public Author(string pAu_id, string pAu_lname, string pAu_fname, string pPhone, string pAddress, string pCity, string pState, string pZip,  bool pContract)
        {
            Au_id = pAu_id;
            Au_lname = pAu_lname;
            Au_fname = pAu_fname;
            Phone = pPhone;
            Address = pAddress;
            City = pCity;
            State = pState;
            Zip = pZip;
            Contract = pContract;
        }

        public string Au_id { get; set; }
        public string Au_lname { get; set; }
        public string Au_fname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public bool Contract { get; set; }
    }
}
