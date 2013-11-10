using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiBook.ProcessingArchitecture.ProcessesApi.v2.Models;

namespace WebApiBook.ProcessingArchitecture.ProcessesApi.v2.Controllers
{
    public class ProcessesController : ApiController
    {
        public ProcessCollectionState Get(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return new ProcessCollectionState
            {
                Processes = Process
                    .GetProcessesByName(name)
                    .Select(p => new ProcessState(p))
            };
        }
    }
}
