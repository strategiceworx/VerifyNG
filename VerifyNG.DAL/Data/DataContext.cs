using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerifyNG.Model;

namespace VerifyNG.DAL.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection") { }

        /// <summary>
        ///  any entity to be persisted must be declared here.
        /// </summary>
        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonEducation> PersonEducations { get; set; }
        public DbSet<PersonExamination> PersonExaminations { get; set; }
        public DbSet<PersonWorkExperience> PersonWorkExperience { get; set; }
        public DbSet<PersonQualification> PersonQualifications { get; set; }
        public DbSet<RetiredWorker> RetiredWorkers { get; set; }
        public DbSet<ActiveWorker> ActiveWorkers { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }

    }
}
