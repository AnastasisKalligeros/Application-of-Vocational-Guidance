using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ApplicationForMissingAnimals
{
     
    public partial class RegisterForm : Form
    {
        string gender;
        MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;pwd=;database=appdb");
        
    
      
        public RegisterForm()
        {

            InitializeComponent();
         
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void confirmpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void createaccount_Click(object sender, EventArgs e)
        {
            if (firstname.Text == "" || lastname.Text == "" || usernamee.Text == "" || emaill.Text == "" || password.Text == "" || confirmpassword.Text == "" && password.Text.Equals(confirmpassword.Text))
            {
                label2.Visible = true;
                label2.Text = "Συμπληρώστε όλα τα πεδία!";
                label5.Visible = false;
                emaill.Focus();
                return;
            }

            else if(validate_emailaddress.IsMatch(emaill.Text) != true)
            { 
                label4.Visible = true;
                label4.Text = "Λάθασμένη μορφή email!";
                emaill.Focus();
                return;
            }
            else
            {
                label2.Visible = false;
                label5.Visible = true;
                label4.Visible = false;
                label5.Text ="Έγκυρη μορφή email!";
            



          
           
  
                

                string input_fname = firstname.Text;
                string input_lname = lastname.Text;
                string input_user = usernamee.Text;
                string input_email = emaill.Text;
                string input_pass = password.Text;
                string input_age = dateTimePicker1.Text;
                

                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "localhost";
                builder.UserID = "root";
                builder.Password = "";
                builder.Database = "appdb";
                MySqlConnection connection = new MySqlConnection(builder.ToString());
                connection.Open();

               
                


                string newuser_sql = "INSERT INTO newuser(firstname, lastname, username, email, password, gender,age) VALUES (@fname,@lname,@user,@email,@pass,@gen,@ag)";
                MySqlCommand newuser = new MySqlCommand(newuser_sql, connection);
                newuser.CommandText = newuser_sql;
                newuser.Parameters.AddWithValue("@fname", input_fname);
                newuser.Parameters.AddWithValue("@lname", input_lname);
                newuser.Parameters.AddWithValue("@user", input_user);
                newuser.Parameters.AddWithValue("@email", input_email);
                newuser.Parameters.AddWithValue("@pass",input_pass);
                newuser.Parameters.AddWithValue("@gen", gender);
                newuser.Parameters.AddWithValue("@ag", input_age);
                string progresses= "progressc1q1, progressc1q2, progressc1q3, progressc2q1, progressc2q2, progressc2q3, progressc3q1, progressc3q2, progressc3q3, progressc4q1, progressc4q2, progressc4q3, progressc5q1, progressc5q2, progressc5q3, progressc6q1, progressc6q2, progressc6q3";
                string progress_sql = "INSERT INTO progress(username, " + progresses + ") VALUES ('"+input_user+"',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0)";
                MySqlCommand usprogress = new MySqlCommand(progress_sql, connection);


                if (password.Text.Equals(confirmpassword.Text))
                {
                    if (ckeckUsername())
                    {
                        label1.Text = "Το όνομα χρήστη υπάρχει ήδη!";
                    }
                    else
                    {
                        if (newuser.ExecuteNonQuery() == 1)
                        {

                            MySqlDataReader reader;
                            reader = usprogress.ExecuteReader();
                            reader.Read();
                            this.Hide();
                            mainform Mainform = new mainform();
                            Mainform.uname = input_user;
                            Mainform.Show();
                        }                      

                    }
                }
                else
                {
                    label3.Text = "Δεν υπάρχει επιβεβαίωση κωδικού!";
                }
                connection.Close();
            }
            
        }
        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }
        public Boolean ckeckUsername()
        {
            String username = usernamee.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM newuser WHERE username=@usn", con);

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;

            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void labelGoToLogin_MouseEnter(object sender, EventArgs e)
        {
            labelGoToLogin.ForeColor = Color.White;
        }

        private void labelGoToLogin_MouseLeave(object sender, EventArgs e)
        {
            labelGoToLogin.ForeColor = Color.White;
        }

        private void labelGoToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
        static Regex validate_emailaddress = email_validation();

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                confirmpassword.UseSystemPasswordChar = false;
            }
            else
            {
                confirmpassword.UseSystemPasswordChar = true;
            }
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
           gender = "Male";
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
                
            RegisterHelper registerHelper = new RegisterHelper();
            registerHelper.Show();
        }
    }
    }

