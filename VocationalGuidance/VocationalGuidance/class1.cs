using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ApplicationForMissingAnimals.mainform;

namespace ApplicationForMissingAnimals
{
    public partial class class1 : Form
    {
        public string lessonname;
        public string username;
        public int count;
        public class1()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            NavigationStack.FormStack.Push(this);
        }

        private void class1_Load(object sender, EventArgs e)
        {
            label1.Text = "Καλωσήρθες στην " + lessonname;
            count++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Statistics form = new Statistics();
            form.count = count;
            form.username = username;
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainform form = new mainform();
            form.uname = username;
            form.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName.ToString()+ "/Diafaneies Kai Akhseis Ekp.Log/DYS/Arxitektonikh/Chapter 2 Instructions Language of the Computer.pdf");


        }

        private void button5_Click(object sender, EventArgs e)
        {
            QuizForm form = new QuizForm();
            form.classname = "c1q1";
            form.username = username;
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            QuizForm form = new QuizForm();
            form.classname = "c1q3";
            form.username = username;
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName.ToString() + "/Diafaneies Kai Akhseis Ekp.Log/DYS/Arxitektonikh/Chapter 3 Arithmetic for Computers.pdf");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mainform form = new mainform();
            form.uname = username;
            form.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            QuizForm form = new QuizForm();
            form.classname = "c1q2";
            form.username = username;
            form.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            classHelper ClassHelper = new classHelper();
            ClassHelper.Show();
        }
    }
}
