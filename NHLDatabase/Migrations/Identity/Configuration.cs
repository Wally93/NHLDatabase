namespace NHLDatabase.Migrations.Identity
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using NHLDatabase.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NHLDatabase.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Identity";
        }

        protected override void Seed(ApplicationDbContext context)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            if (!roleManager.RoleExists("Admin"))
                roleManager.Create(new IdentityRole("Admin"));

            if (!roleManager.RoleExists("Guest"))
                roleManager.Create(new IdentityRole("Guest"));

            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            if (userManager.FindByEmail("admin@email.com") == null)
            {
                var user = new ApplicationUser
                {
                    Email = "admin@email.com",
                    UserName = "admin@email.com",
                };

                var result = userManager.Create(user, "P@$$w0rd");
                if (result.Succeeded)
                    userManager.AddToRole(userManager.FindByEmail(user.Email).Id, "Admin");
            }

            if (userManager.FindByEmail("guest@email.com") == null)
            {
                var user = new ApplicationUser
                {
                    Email = "guest@email.com",
                    UserName = "guest@email.com",
                };

                var result = userManager.Create(user, "P@$$w0rd");
                if (result.Succeeded)
                    userManager.AddToRole(userManager.FindByEmail(user.Email).Id, "Guest");
            }


        }
    }
}
