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

namespace ApplicationForMissingAnimals
{
    public partial class mainform : Form
    {
        public string uname;
        public mainform()
        {
            InitializeComponent();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;pwd=;database=appdb");
            con.Open();
            MySqlCommand com = new MySqlCommand("SELECT firstname FROM newuser WHERE username='" + uname + "'", con);

            MySqlDataReader mySqlDataReader = com.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                label1.Text = "Καλωσήρθες "+mySqlDataReader.GetString(0)+"!";
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            class6 form = new class6();
            form.lessonname = button8.Text;
            form.username = uname;

            form.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible=!panel1.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            class1 form = new class1();
            form.lessonname = button4.Text;
            form.username = uname;
            form.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            class2 form = new class2();
            form.lessonname = button5.Text;
            form.username = uname;

            form.Show();
            this.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            class3 form = new class3();
            form.lessonname = button7.Text;
            form.username = uname;

            form.Show();
            this.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            class4 form = new class4();
            form.lessonname = button6.Text;
            form.username = uname;

            form.Show();
            this.Close();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            class5 form = new class5();
            form.lessonname = button9.Text;
            form.username = uname;

            form.Show();
            this.Close();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Preferences form = new Preferences();
            form.username = uname;
            form.Show();
            this.Close();
        }

        public static class NavigationStack
        {
            public static Stack<Form> FormStack = new Stack<Form>();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
   
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            mainHelper form = new mainHelper();

            form.Show();
        }
    }
}
