﻿using System;
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
    public partial class mainHelper : Form
    {
        public mainHelper()
        {
            InitializeComponent();
        }

        private void mainHelper_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form previousForm = Form.ActiveForm;
            previousForm.Show();
            this.Close();
        }
    }
}