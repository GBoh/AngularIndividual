using MFTWebFormAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MFTWebFormAPI.api {

    //[Authorize]
    [Route("api/mftFormApi", Name = "mftForm")]
    public class MFTFormController : ApiController {
        private MFTService _service;
        public MFTFormController(MFTService service) {
            _service = service;
        }

        public Array Get() {
            return _service.GetDropDowns();
        }

        public HttpResponseMessage Push(MFTFormSubmissionDTO mftForm) {
            if (ModelState.IsValid) {
                _service.AddMFTForm(mftForm);
                return Request.CreateResponse(HttpStatusCode.OK, mftForm);
            }
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        }

    }
}
