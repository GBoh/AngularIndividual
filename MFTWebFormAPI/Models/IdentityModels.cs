﻿using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System.Data.Entity;
using MFTWebFormAPI.Domain;
using System.Collections;
using System.Collections.Generic;

namespace MFTWebFormAPI.Models {
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<MFTFormSubmission> MFTForms { get; set; }
        public IList<Term> Terms { get; set; }
        public IList<Group> Groups { get; set; }
        public IList<ApplicationUser> Students { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType) {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false) {
        }

        public static ApplicationDbContext Create() {
            return new ApplicationDbContext();
        }

        public IDbSet<Event> Events { get; set; }
        public IDbSet<Group> Groups { get; set; }
        public IDbSet<ObservableData> ObservableData { get; set; }
        public IDbSet<Supervisor> Supervisors { get; set; }
        public IDbSet<MFTFormSubmission> MFTFormSubmissions { get; set; }
        public IDbSet<Term> Terms { get; set; }
        public IDbSet<School> Schools { get; set; }

    }
}