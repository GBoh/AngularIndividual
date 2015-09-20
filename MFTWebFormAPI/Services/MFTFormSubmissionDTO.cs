using MFTWebFormAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFTWebFormAPI.Services {
    public class MFTFormSubmissionDTO {
        public DateTime? Date { get; set; }
        public DateTime? StartTime { get; set; }
        public string ClockHours { get; set; }
        public string Event { get; set; }
        public string Group { get; set; }
        public string ObservableData { get; set; }
        public string Supervisor { get; set; }
        public string SupervisorInitials { get; set; }
        public string Comments { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public TermDTO Term { get; set; }
    }
}