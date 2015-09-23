using MFTWebFormAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFTWebFormAPI.Domain {
    public class Term {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<MFTFormSubmission> MFTForms { get; set; }
        public string User { get; set; }
    }
}