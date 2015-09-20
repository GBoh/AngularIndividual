using MFTWebFormAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFTWebFormAPI.Services {
    public class GroupDTO {
        public string Name { get; set; }
        public IList<ApplicationUser> Users { get; set; }
    }
}