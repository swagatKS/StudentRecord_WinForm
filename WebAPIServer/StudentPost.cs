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

        public string getName() { return name; }
        public string getDob() { return dob; }
        public string getClgname() { return clgname; }
        public char getGender() { return gender; }
        public string getPhno() { return phno; }
        public decimal getCgpa() { return cgpa; }
        public string getEmail() { return email; }
        public List<string> getSkills() { return skills; }

        public StudentPost(string name, string dob, string clg, char g, string phno, decimal cgpa, string mail, List<string> skill)
        {
            this.name = name;
            this.dob = dob;
            this.clgname = clg;
            this.gender = g;
            this.phno = phno;
            this.cgpa = cgpa;
            this.email = mail;
            this.skills = skill;
        }

    }
}