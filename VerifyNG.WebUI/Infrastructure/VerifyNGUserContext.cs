using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerifyNG.WebUI.Models;

namespace VerifyNG.WebUI.Infrastructure
{
    public class VerifyNGUserContext : IdentityDbContext<VerifyNGUser>
    {
        public VerifyNGUserContext() : base("VerifyNGConnection", throwIfV1Schema: false)
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public static VerifyNGUserContext Create()
        {
            return new VerifyNGUserContext();
        }
    }
}
