using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerifyNG.Model
{
    class BankAccount
    {
        public int id { get; set; }
        public ICollection<Person> PersonId { get; set; }
        public string BankName { get; set; }
        public int NubanNumber { get; set; }
        public bool BVNLinked { get; set; }
    }
}
