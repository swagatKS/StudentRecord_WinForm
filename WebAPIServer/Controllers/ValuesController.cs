using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;

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
        public IHttpActionResult Post([FromBody] StudentPost student)
        {
            if (student == null)
            {
                return BadRequest("Invalid student data");
            }

            string skillList = "[";
            foreach (string skill in student.skills)
            {
                skillList += skill;
                skillList += ",";
            }
            skillList += "]";
            string logMessage = $"Received student information: Name - {student.name}, DOB - {student.dob}, College Name - {student.clgname}, Gender - {student.gender}, PhNo - {student.phno}, CGPA - {student.cgpa}, Email - {student.email}, Skills - {skillList}\n";

            System.Diagnostics.Trace.WriteLine(logMessage);
            return Ok(student);
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
