﻿using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReadyApi.Controllers
{
    [RoutePrefix("")]
    public class DefaultController : ApiController
    {
        [Route("")]
        [HttpGet]
        public HttpResponseMessage Home()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Moved);
            response.Headers.Location = new Uri(Request.RequestUri + "\\swagger");
            return response;
        }

        [Route("health-check")]
        [HttpGet]
        public HttpResponseMessage Check()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, true);
            return response;
        }
    }
}