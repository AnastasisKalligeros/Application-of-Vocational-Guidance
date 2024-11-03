using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ApplicationForMissingAnimals
{
    public partial class LoginForm : Form
    {
        


        public LoginForm()
        {
            InitializeComponent();
           
            this.password.AutoSize = false;
            this.password.Size = new Size(this.password.Size.Width, 50);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

    
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Click(object sender, EventArgs e)
        {




            MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;pwd=;database=appdb");
            if (username.Text == "" || password.Text == "" )
            {
                label2.Visible = true;
                label2.Text = "Παρακαλώ συμπληρώστε όλα τα πεδία!";
                label1.Visible = false;
            }

            else
            {
                label2.Visible = false;



                string input_user = username.Text;
                string input_pass = password.Text;

                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "localhost";
                builder.UserID = "root";
                builder.Password = "";
                builder.Database = "appdb";
                MySqlConnection connection = new MySqlConnection(builder.ToString());
                connection.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT COUNT(*) FROM newuser where username='" + username.Text + "' and password='" + password.Text + "'", con);
                string newuser_sql = "SELECT COUNT(*) FROM newuser where (username,password) VALUES(@user,@pas)";
                MySqlCommand newuser = new MySqlCommand(newuser_sql, connection);
                newuser.CommandText = newuser_sql;

                newuser.Parameters.AddWithValue("@user", input_user);
                newuser.Parameters.AddWithValue("@pass", input_pass);


                      DataTable dt = new DataTable();
                
                                 sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1" )
                                 {
                                     this.Hide();
                                     
                    mainform form = new mainform();
                    form.uname = input_user;
                    form.Show();
                                 }
                                 else
                                     label1.Text = "Έχετε χρησιμοποιήσει λάθος όνομα χρήστη ή κωδικό!";
                

                            }

                            }
                
            

        private void labelGoToSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void labelGoToSignUp_MouseEnter(object sender, EventArgs e)
        {
            labelGoToSignUp.ForeColor = Color.White;
        }

        private void labelGoToSignUp_MouseLeave(object sender, EventArgs e)
        {
            labelGoToSignUp.ForeColor = Color.White;
        }

        private void forgotpassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forgotpassword forgotpassword = new Forgotpassword();
            forgotpassword.Show();
        }

        private void forgotpassword_MouseEnter(object sender, EventArgs e)
        {
            forgotpassword.ForeColor = Color.White;
        }

        private void forgotpassword_MouseLeave(object sender, EventArgs e)
        {
            forgotpassword.ForeColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoginHelper form = new LoginHelper();
       
            form.Show();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
        
        
    
    

