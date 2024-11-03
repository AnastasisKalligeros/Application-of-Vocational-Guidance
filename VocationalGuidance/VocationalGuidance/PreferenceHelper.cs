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
    public partial class PreferenceHelper : Form
    {
        public PreferenceHelper()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form previousForm = Form.ActiveForm;
            previousForm.Show();
            this.Close();
        }
    }
}
