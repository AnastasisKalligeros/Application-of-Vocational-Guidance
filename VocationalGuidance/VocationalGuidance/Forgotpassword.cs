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
    public partial class Forgotpassword : Form
    {
        
        public Forgotpassword()
        {
            InitializeComponent();
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createnewpassword_Click(object sender, EventArgs e)
        {
           


            MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;pwd=;database=appdb");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from newuser where username='" + username.Text + "'", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                label1.Text = "Ο κωδικό σας είναι: "  +dr.GetValue(5).ToString();  
            }
            else
            {
                MessageBox.Show("Δεν βρέθηκε κάποια αντιστοιχία. Παρακαλούμε προσπαθήστε ξανά!");
            }
            if (username.Text == "" )
            {
                label2.Visible = true;
                label2.Text = "Παρακαλώ εισάγετε όνομα χρήστη!";
            }

            else
            {
                
                label2.Visible = false;

            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            ForgotPasswordHelper forgotpasswordhelper = new ForgotPasswordHelper();


            forgotpasswordhelper.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
