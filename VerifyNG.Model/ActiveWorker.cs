using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerifyNG.Model
{
    public class ActiveWorker
    {
        public int id { get; set; }
        public ICollection<Person> PersonId { get; set; }
        public string VerifiedAge { get; set; }
        public string VerifiedWorkStartDate { get; set; }
    }
}
