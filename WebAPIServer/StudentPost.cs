using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIServer
{
    public class StudentPost
    {
        public string name;
        public string dob;
        public string clgname;
        public char gender;
        public string phno;
        public decimal cgpa;
        public string email;
        public List<string> skills;
    }
}