using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerifyNG.Model
{
    class PersonWorkHistory
    {
        public int id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string JobTitle { get; set; }
        public string Function { get; set; }
        public string EmploymentType { get; set; }
    }
}
