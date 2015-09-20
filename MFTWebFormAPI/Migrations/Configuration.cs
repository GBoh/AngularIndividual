namespace MFTWebFormAPI.Migrations
{
    using Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MFTWebFormAPI.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MFTWebFormAPI.Models.ApplicationDbContext context)
        {
            context.Events.AddOrUpdate(
                new Event { Name = "IT - Individual Thearapy" },
                new Event { Name = "FT - Family Thearapy" },
                new Event { Name = "GT - Group Thearapy" },
                new Event { Name = "ITS - Individual Thearapy with Supervisor" },
                new Event { Name = "FTS - Famil Thearapy with Supervisor" },
                new Event { Name = "GTS - Group Thearapy with Supervisor" },
                new Event { Name = "ITT - Individual Thearapy - Team Member" },
                new Event { Name = "FTT - Family Thearapy - Team Member" },
                new Event { Name = "GTT - Group Thearapy - Team Member" }
            );

            context.Groups.AddOrUpdate(
                new Group { Name = "Practice" },
                new Group { Name = "Off Campus Intern Site" }
            );

            context.ObservableData.AddOrUpdate(
                new ObservableData { Name = "Supervisor in Room" },
                new ObservableData { Name = "Used Recording" }
            );

            context.Supervisors.AddOrUpdate(
                new Supervisor { Name = "AAMFT Approved" },
                new Supervisor { Name = "Stat LMFT Approved" },
                new Supervisor { Name = "Non-Approved" }
            );
        }
    }
}
