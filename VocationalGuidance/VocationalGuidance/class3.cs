using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationForMissingAnimals
{
    public partial class class3 : Form
    {
        public string lessonname;
        public string username;
        public int count;

        public class3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Statistics form = new Statistics();
            form.count = count;
            form.username = username;
            form.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void class3_Load(object sender, EventArgs e)
        {
            label1.Text = "Καλωσήρθες στις " + lessonname;
            count++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainform form = new mainform();
            form.uname = username;
            form.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QuizForm form = new QuizForm();
            form.classname = "c3q1";
            form.username = username;
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            QuizForm form = new QuizForm();
            form.classname = "c3q2";
            form.username = username;
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            QuizForm form = new QuizForm();
            form.classname = "c3q3";
            form.username = username;
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName.ToString() + "/Diafaneies Kai Akhseis Ekp.Log/PSY/Baseis Dedomenwn/01-DBintro.pdf");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName.ToString() + "/Diafaneies Kai Akhseis Ekp.Log/PSY/Baseis Dedomenwn/02-RelModelAlgebra.pdf");
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            classHelper ClassHelper = new classHelper();
            ClassHelper.Show();
        }
    }
}
