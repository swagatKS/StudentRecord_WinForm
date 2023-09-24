using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using Assignment1_intern;

namespace WebAPIServer.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public HttpResponseMessage Post([FromBody] Student student)
        {
            if (student == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid student data");
            }

            LogStudentInformation(student);
            return Request.CreateResponse(HttpStatusCode.OK, student, Configuration.Formatters.JsonFormatter);
        }

        private void LogStudentInformation(Student student)
        {
            string logMessage = $"Received student information: Name - {student.Name}, Age - {student.Age}";

            // Write to the event log
            EventLog eventLog = new EventLog();
            eventLog.Source = "YourApplicationName"; // Set this to your application name
            eventLog.WriteEntry(logMessage, EventLogEntryType.Information);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
