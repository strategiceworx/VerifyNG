using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerifyNG.DAL.Model
{
    public class RetiredWorker
    {
        public int id { get; set; }
        public ICollection<Person> PersonId { get; set; }
        public string VerifiedAge { get; set; }
        public string VerifiedWorkStartDate { get; set; }
        public string VerifiedWorkEndDate { get; set; }

    }
}
