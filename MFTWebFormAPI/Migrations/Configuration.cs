namespace MFTWebFormAPI.Migrations {
    using Domain;
    using Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;


    internal sealed class Configuration : DbMigrationsConfiguration<MFTWebFormAPI.Models.ApplicationDbContext> {
        public Configuration() {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MFTWebFormAPI.Models.ApplicationDbContext context) {
            ApplicationUserManager manager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));

             

            var user = manager.FindByName("admin@mft.com");
            if (user == null) {
                user = new ApplicationUser {
                    UserName = "admin@mft.com",
                    Email = "admin@mft.com",
                    FirstName = "Greg",
                    LastName = "Bohanon",
                };
                manager.Create(user, "P@ssw0rd123!");
            };

            context.Events.AddOrUpdate(
                e => e.Name,
                    new Event { Name = "IT - Individual Thearapy" },
                    new Event { Name = "FT - Family Thearapy" },
                    new Event { Name = "GT - Group Thearapy" },
                    new Event { Name = "ITS - Individual Thearapy with Supervisor" },
                    new Event { Name = "FTS - Family Thearapy with Supervisor" },
                    new Event { Name = "GTS - Group Thearapy with Supervisor" },
                    new Event { Name = "ITT - Individual Thearapy - Team Member" },
                    new Event { Name = "FTT - Family Thearapy - Team Member" },
                    new Event { Name = "GTT - Group Thearapy - Team Member" }
                );

            context.Groups.AddOrUpdate(
                g => g.Name,
                    new Group { Name = "Practice" },
                    new Group { Name = "Off Campus Intern Site" }
                );

            context.ObservableData.AddOrUpdate(
                o => o.Name,
                    new ObservableData { Name = "Supervisor in Room" },
                    new ObservableData { Name = "Used Recording" }
                );

            context.Supervisors.AddOrUpdate(
                s => s.Name,
                    new Supervisor { Name = "AAMFT Approved" },
                    new Supervisor { Name = "State LMFT Approved" },
                    new Supervisor { Name = "Non-Approved" }
                );

            context.Schools.AddOrUpdate(
                sc => sc.Name,
                new School {
                    Name = "Our Lady of the Lake University",
                    
                    //Events = context.Events.Include(e => e.Name).ToList(),
                    //Groups = context.Groups.Include(g => g.Name).ToList(),
                    //ObservableData = context.ObservableData.Include(o => o.Name).ToList(),
                    //Supervisors = context.Supervisors.Include(s => s.Name).ToList(),
                }
            );
        }
    }
}
