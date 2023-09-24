using Microsoft.VisualBasic.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperSimpleTcp;

namespace Assignment1_intern
{
    public class Students : IEnumerable<Student>
    {


        private Dictionary<string , Student> StudentMap =  new Dictionary<string, Student>();

        public IEnumerator<Student> GetEnumerator()
        {
            return StudentMap.Values.GetEnumerator();
        }

        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public bool AddStudent(Student student)
        {
            bool RetVal = false;

            if (student != null && !StudentMap.ContainsKey(student.getName()))
            {
                StudentMap.Add(student.getName(), student);
                RetVal = true;
            }

            return RetVal;
        }

        public bool ModifyStudent(Student student)
        {
            bool RetVal = false;

            if (student != null)
            {
                if(StudentMap.ContainsKey(student.getName()))
                {
                    StudentMap[student.getName()] = student;    
                }
                else
                {
                    StudentMap.Add(student.getName() , student);
                }
                RetVal = true;
            }

            return RetVal;
        }

        public bool DeleteStudent(String Name) 
        {
            bool RetVal = false;

            if(StudentMap.ContainsKey(Name)) 
            {
                StudentMap.Remove(Name);
                RetVal = true;
            }
            
            return RetVal;
        }

        public int StudentCount()
        {
            return StudentMap.Count;
        }

        public string[] GetStudents()
        {
            string[] strings = new string[StudentMap.Count];

            int i = 0;
            foreach(string s in StudentMap.Keys)
            {
                strings[i] = s;
                i++;
            }

            return strings;
        }

        public string ObjectTo_csv()
        {
            long logSize = 10 * 1024 * 1024;
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            path = path.Substring(0, path.Length - 43);
            //string path = "C:\\Users\\ksswa\\source\\repos\\Assignment1_intern\\";
            string logFile = path + "StudentData.csv";
            try
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);

                bool exists = Directory.Exists(path);
                if (!exists)
                    Directory.CreateDirectory(path);


                if (logFile.Trim().Length <= 0)
                {
                    logFile = path + "ServiceHost-" + DateTime.Now.ToString("yyyyMMdd-HHmmssfff") + ".csv";
                }
                else
                {
                    FileInfo fileInfo = new FileInfo(logFile);
                    if (fileInfo.Length > logSize)
                    {
                        logFile = path + "ServiceHost-" + DateTime.Now.ToString("yyyyMMdd-HHmmssfff") + ".csv";
                    }
                }

                using (FileStream fs = File.Open(logFile, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    lock (fs)
                    {
                        fs.SetLength(0);
                    }
                }


                StreamWriter wtr = new StreamWriter(logFile, true);
                string message = "";
                foreach (Student s in StudentMap.Values)
                {
                    message += s.getName() + "," + s.getDob() + "," + s.getClgname() + "," + char.ToString(s.getGender()) + "," + s.getPhno() + "," + s.getCgpa().ToString() + "," + s.getEmail() + "," + string.Join("-", s.getSkills().ToArray()) + "\n";

                }

                wtr.Write(message); // write the log message.
                wtr.Close();
                wtr.Dispose();
                
                return message;
            }

            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                return "not_csv";
            }
        }
        
    }
}
