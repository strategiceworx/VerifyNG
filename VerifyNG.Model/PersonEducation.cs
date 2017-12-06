using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerifyNG.Model;

namespace VerifyNG.Model
{
    class PersonEducation
    {
        public int id { get; set; }
        public DateTime YearStarted { get; set; }
        public DateTime YearCompleted { get; set; }
        public string Institution { get; set; }
        public string Qualification { get; set; }
        public ICollection<Person> PersonId { get; set; }
        public string DegreeTitle { get; set; }
    }
}
