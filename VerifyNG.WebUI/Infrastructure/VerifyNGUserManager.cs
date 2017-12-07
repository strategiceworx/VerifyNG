using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VerifyNG.WebUI.Models;

namespace VerifyNG.WebUI.Infrastructure
{
    public class VerifyNGUserManager : UserManager<VerifyNGUser>
    {
        public VerifyNGUserManager(IUserStore<VerifyNGUser> store) : base(store) { }

        public VerifyNGUserManager Create(IdentityFactoryOptions<VerifyNGUserManager> options, IOwinContext context)
        {
            var appDbContext = context.Get<VerifyNGUserContext>();
            var appUserManager = new VerifyNGUserManager(new UserStore<VerifyNGUser>(appDbContext));

            return appUserManager;
        }
    }
}