using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerifyNG.DAL.Data;
using VerifyNG.Model;

namespace VerifyNG.DAL.Repositories
{
    public class PersonRepository : RepositoryBase<Person>
    {
        public PersonRepository(DataContext context) : base(context)
        {
            if(context == null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
