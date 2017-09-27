using AddressBook.Domain;
using AddressBook.Models.Requests;
using AddressBook.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WikiWebStarter.Web.Models.Responses;

namespace AddressBook.Controllers.Api
{
    [RoutePrefix("api/contact")]
    public class ContactApiController : ApiController
    {
        [Route, HttpPost]
        public HttpResponseMessage Insert(ContactAddRequest model)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            int id = ContactService.Insert(model);

            ItemResponse<int> response = new ItemResponse<int>();
            response.Item = id;
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        [Route("{id:int}"), HttpPut]
        public HttpResponseMessage Update(ContactUpdateRequest model)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            ContactService.Update(model);

            SuccessResponse response = new SuccessResponse();
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        [Route("{id:int}"), HttpGet]
        public HttpResponseMessage SelectById(int id)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            // do i need the above?

            ItemResponse<Contact> response = new ItemResponse<Contact>();
            response.Item = ContactService.SelectById(id);

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        [Route(""), HttpGet]
        public HttpResponseMessage SelectAll()
        {

            ItemResponse<List<Contact>> response = new ItemResponse<List<Contact>>();
            response.Item = ContactService.SelectAll();

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        [Route("{id:int}"), HttpDelete]
        public HttpResponseMessage DeleteById(int id)
        {
            ContactService.Delete(id);

            SuccessResponse response = new SuccessResponse();

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }
    }
}
