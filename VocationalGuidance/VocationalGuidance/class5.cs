﻿using System;
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
    public partial class class5 : Form
    {
        public string lessonname;
        public string username;
        public int count;

        public class5()
        {
            InitializeComponent();
        }

        private void class5_Load(object sender, EventArgs e)
        {
            label1.Text = "Καλωσήρθες στην " + lessonname;
            count++;
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
            System.Diagnostics.Process.Start(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName.ToString() + "/Diafaneies Kai Akhseis Ekp.Log/TLES/C++/slides2.pdf");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName.ToString() + "/Diafaneies Kai Akhseis Ekp.Log/TLES/C++/slides3.pdf");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QuizForm form = new QuizForm();
            form.classname = "c5q1";
            form.username = username;
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            QuizForm form = new QuizForm();
            form.classname = "c5q2";
            form.username = username;
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            QuizForm form = new QuizForm();
            form.classname = "c5q3";
            form.username = username;
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mainform form = new mainform();
            form.uname = username;
            form.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            classHelper ClassHelper = new classHelper();
            ClassHelper.Show();
        }
    }
}