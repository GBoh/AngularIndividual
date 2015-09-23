using MFTWebFormAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MFTWebFormAPI.Services {
    public class TermDTO {
        public int Id { get; set; }

        [Required(ErrorMessage = "Must enter a term name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        public IList<MFTFormSubmissionDTO> MFTForms { get; set; }

        public string User { get; set; }
    }
}