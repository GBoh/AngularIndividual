using MFTWebFormAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MFTWebFormAPI.api {
    [Authorize]
    [Route("api/term", Name = "TermApi")]
    public class TermController : ApiController {
        private MFTService _service;
        public TermController(MFTService service) {
            _service = service;
        }

        public IEnumerable<TermDTO> Get() {
            return _service.ListTerms();
        }

        public HttpResponseMessage Post(TermDTO term) {
            if (ModelState.IsValid) {
                _service.AddTerm(term);
                return Request.CreateResponse(HttpStatusCode.OK, term);
            }
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        }
    };
};
