using MFTWebFormAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFTWebFormAPI.Domain {
    public class School {
        public int Id { get; set; }
        public string Name { get; set; }
        public ApplicationUser Members { get; set; }
        public IList<Event> Events { get; set; }
        public IList<Group> Groups { get; set; }
        public IList<ObservableData> ObservableData { get; set; }
        public IList<Supervisor> Supervisors { get; set; }

    }
}