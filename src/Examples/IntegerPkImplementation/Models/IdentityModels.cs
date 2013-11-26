﻿using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using AspNet.Identity.EntityFramework.Multitenant;

namespace IntegerPkImplementation.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : MultitenantIdentityUser<int, int, ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim>
    {
    }

    public class ApplicationUserRole : IdentityUserRole<int>
    {
    }

    public class ApplicationUserLogin : MultitenantIdentityUserLogin<int, int>
    {
    }

    public class ApplicationUserClaim : IdentityUserClaim<int>
    {
    }

    public class ApplicationRole : IdentityRole<int, ApplicationUserRole>
    {
    }

    public class ApplicatonUserStore :
        MultitenantUserStore<ApplicationUser, ApplicationRole, int, int, ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim>
    {
        public ApplicatonUserStore(DbContext context)
            : base(context)
        {
        }
    }

    public class ApplicationDbContext
        : MultitenantIdentityDbContext<ApplicationUser, ApplicationRole, int, int, ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}