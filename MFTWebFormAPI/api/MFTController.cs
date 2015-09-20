using MFTWebFormAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MFTWebFormAPI.api {
    [Authorize]
    [RoutePrefix("api/mft")]
    public class MFTController : ApiController {
        private MFTService _service;
        public MFTController(MFTService service) {
            _service = service;
        }

        [HttpGet]
        [Route("terms")]
        public IEnumerable<TermDTO> ListTerms() {
            return _service.ListTerms();
        }
    }
}
