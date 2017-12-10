using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerifyNG.DAL;

namespace VerifyNG.Model
{
    public class Person
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public DateTime DOB { get; set; }
        public string TelephoneNumber { get; set; }
        public string MMaidenName { get; set; }
        public string MaritalStatus { get; set; }
        public string Address { get; set; }
        public string bankVerificationNumber { get; set; }
        
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
