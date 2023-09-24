using System.Text.RegularExpressions;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using SuperSimpleTcp;
using System.Text;
using System.Windows.Forms;
using System.Net.Http.Json;
using System.Text.Json;

namespace Assignment1_intern
{
    public partial class Form1 : Form
    {
        Students students;
        public Form1()
        {
            InitializeComponent();
            students = loadStudentsFromCSV();
        }

        SimpleTcpClient client;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient(serverIP.Text);
            client.Events.DataReceived += Events_DataReceived;
            client.Events.Connected += Events_Connected;
            client.Events.Disconnected += Events_Disconnected;
        }

        private void Events_Disconnected(Object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                historyBox.Text += $"Server disconnected.{Environment.NewLine}";
                buttonConnect.Enabled = true;
            });
        }

        private void Events_DataReceived(object sender, SuperSimpleTcp.DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                byte[] dataBytes = e.Data.ToArray();
                string dataString = Encoding.UTF8.GetString(dataBytes);
                historyBox.Text += $"Server: {dataString}{Environment.NewLine}";
            });
        }

        private void Events_Connected(Object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                historyBox.Text += $"Server connected.{Environment.NewLine}";
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (studentdetail_validate())
            {

                MessageBox.Show("Submitted Successfully!");

                Student stud = loadStudent();

                this.students.AddStudent(stud);

                if (students.StudentCount() > 0)
                {
                    MessageBox.Show("Total Students: " + students.StudentCount().ToString());
                }
            }

        }





        public bool isvalid_name(string name)
        {
            Regex check = new Regex(@"^([a-z-A-Z\s]+)$");
            bool valid = false;
            valid = check.IsMatch(name);
            if (valid)
            {
                return valid;
            }
            else
            {

                return valid;
            }

        }

        public bool isvalid_clgname(string clgname)
        {
            Regex check = new Regex(@"^([a-z-A-Z\s]+)$");
            bool valid = false;
            valid = check.IsMatch(clgname);
            if (valid)
            {
                return valid;
            }
            else
            {

                return valid;
            }

        }



        public bool isvalid_mail(string mail)
        {
            Regex check = new Regex(@"^\w+[\w-\.]+\@\w{5}\.[a-z]{2,3}$");
            bool valid = false;
            valid = check.IsMatch(mail);
            if (valid)
            {
                return valid;
            }
            else
            {

                return valid;
            }
        }
        public bool isvalid_phnum(string phnum)
        {
            Regex ex = new Regex(@"^[1-9][0-9]{9}$");
            bool valid = ex.IsMatch(phnum);
            if (valid)
            {
                return valid;

            }
            else
            {

                return valid;
            }
        }

        public bool isvalid_cgpa(string cgpa)
        {
            Regex check = new Regex(@"^(?:[0-9](?:\.\d{1,2})?|10(?:\.0{1,2})?)$");
            bool valid = false;
            valid = check.IsMatch(cgpa);
            if (valid)
            {
                return valid;
            }
            else
            {

                return valid;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }




        public bool isvalid_age()
        {
            if (DateTime.Today.AddYears(-18) < Convert.ToDateTime(dateTimePicker1.Text))
            {

                return false;
            }
            return true;
        }

        public bool studentdetail_validate()
        {
            if (!isvalid_name(nametextBox.Text))
            {
                MessageBox.Show("Name is not in the required format!");
                return false;
            }
            else if (!isvalid_age())
            {
                MessageBox.Show("Age should be 18 and above!");
                return false;
            }
            else if (!isvalid_clgname(clgnametextBox.Text))
            {
                MessageBox.Show("College Name is not in the required format!");
                return false;
            }
            else if (!(radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked))
            {
                MessageBox.Show("Please select your Gender!.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (!isvalid_phnum(phnotextBox.Text))
            {
                MessageBox.Show("PhNo is invalid!");
                return false;
            }
            else if (!isvalid_cgpa(cgpatextBox.Text))
            {
                MessageBox.Show("CGPA in wrong Format!");
                return false;
            }
            else if (!isvalid_mail(emailtextBox.Text))
            {
                MessageBox.Show("E-Mail in wrong Format!");
                return false;
            }
            else { return true; }
        }

        public Student loadStudent()
        {
            string name = nametextBox.Text;
            string dob = dateTimePicker1.Text;
            string clg = clgnametextBox.Text;
            char gen;
            if (radioButton1.Checked)
            {
                gen = 'M';
            }
            else if (radioButton2.Checked) { gen = 'F'; }
            else if (radioButton3.Checked) { gen = 'T'; }
            else { gen = 'N'; }
            string phno = phnotextBox.Text;
            decimal cgpa = Convert.ToDecimal(cgpatextBox.Text);
            string email = emailtextBox.Text;
            List<string> skills = new List<string>();
            if (checkBox1.Checked) { skills.Add(checkBox1.Text); }
            if (checkBox2.Checked) { skills.Add(checkBox2.Text); }
            if (checkBox3.Checked) { skills.Add(checkBox3.Text); }
            if (checkBox4.Checked) { skills.Add(checkBox4.Text); }
            if (checkBox5.Checked) { skills.Add(checkBox5.Text); }

            Student stud = new Student(name, dob, clg, gen, phno, cgpa, email, skills);

            return stud;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Names = "STUDENT LIST:\n";
            if (students != null && students.StudentCount() > 0)
            {
                foreach (string s in students.GetStudents())
                {
                    if (s != null && s.Length > 0)
                    {
                        Names += s + "\n";
                    }
                    else
                    {
                        Names += "NULL NAME" + "\n";
                    }
                }
            }
            MessageBox.Show(Names);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!students.DeleteStudent(nametextBox.Text))
            {
                MessageBox.Show("Name not in Student List");
            }
            else
            {
                MessageBox.Show("Deleted Successfully");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (studentdetail_validate())
            {

                MessageBox.Show("Submitted Successfully!");

                Student stud = loadStudent();

                this.students.ModifyStudent(stud);

            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            string msg = students.ObjectTo_csv();
            if (msg != "not_csv")
            {
                MessageBox.Show("SAVED!");
                if (client.IsConnected)
                {
                    if (!string.IsNullOrEmpty(msg))
                    {
                        try
                        {
                            client.Send(msg);
                            historyBox.Text += $"Data sent to server.{Environment.NewLine}";
                        }
                        catch (Exception ex)
                        {
                            historyBox.Text += $"Error sending data: {ex.Message}{Environment.NewLine}";
                        }

                    }

                }
            }

            else
            {
                MessageBox.Show("Could not save as a csv file");
            }
        }

        public Students loadStudentsFromCSV()
        {
            Students students = new Students();

            try
            {
                string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
                path = path.Substring(0, path.Length - 43);
                string[] csvLines = File.ReadAllLines(path + "StudentData.csv");
                //string[] csvLines = File.ReadAllLines(@"C:\Users\ksswa\source\repos\Assignment1_intern\StudentData.csv");
                for (int i = 0; i < csvLines.Length; i++)
                {
                    string[] rowData = csvLines[i].Split(',');
                    List<string> skills = new List<string>(rowData[7].Split('-'));
                    Student student = new Student(rowData[0], rowData[1], rowData[2], char.Parse(rowData[3]), rowData[4], Convert.ToDecimal(rowData[5]), rowData[6], skills);

                    students.AddStudent(student);

                }
                return students;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return students;
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect();
                buttonConnect.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            string apiUrl = "http://localhost:64077/api/values";

            using (var httpClient = new HttpClient())
            {
                try
                {
                    // Assuming students is an instance of Students
                    foreach (var student in students)
                    {
                        string json = JsonSerializer.Serialize(student);

                        var response = await httpClient.PostAsJsonAsync(apiUrl, json);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Student data sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error sending student data. Status Code: " + response.StatusCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}