using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationForMissingAnimals
{
    public partial class Preferences : Form
    {
        public string username;
        public Preferences()
        {
            InitializeComponent();
        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            int dysscore = 0;
            int psyscore = 0;
            int tlesscore = 0;
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "appdb";
            MySqlConnection connection = new MySqlConnection(builder.ToString());
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select * from progress where username='"+username+"'";
            MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                dysscore += (int)mySqlDataReader[1];
                dysscore += (int)mySqlDataReader[2];
                dysscore += (int)mySqlDataReader[3];
                dysscore += (int)mySqlDataReader[4];
                dysscore += (int)mySqlDataReader[5];
                dysscore += (int)mySqlDataReader[6];
                psyscore += (int)mySqlDataReader[7];
                psyscore += (int)mySqlDataReader[8];
                psyscore += (int)mySqlDataReader[9];
                psyscore += (int)mySqlDataReader[10];
                psyscore += (int)mySqlDataReader[11];
                psyscore += (int)mySqlDataReader[12];
                tlesscore += (int)mySqlDataReader[13];
                tlesscore += (int)mySqlDataReader[14];
                tlesscore += (int)mySqlDataReader[15];
                tlesscore += (int)mySqlDataReader[16];
                tlesscore += (int)mySqlDataReader[17];
                tlesscore += (int)mySqlDataReader[18];
            }
            if (dysscore >= psyscore && dysscore >= tlesscore)
            {
                label2.Text = "Το υψηλότερο σου σκορ ήταν σην κατεύθυνση Δ.Υ.Σ. με: " + dysscore + " πόντους.Εμεις προτείνουμε: Σχεδιαση ψηφιακων συστηματων.";
                webBrowser1.Navigate("https://www.google.com/search?q=%CE%A3%CF%87%CE%B5%CE%B4%CE%AF%CE%B1%CF%83%CE%B7+%CE%A8%CE%B7%CF%86%CE%B9%CE%B1%CE%BA%CF%8E%CE%BD+%CE%A3%CF%85%CF%83%CF%84%CE%B7%CE%BC%CE%AC%CF%84%CF%89%CE%BD+%CE%BC%CE%B5%CF%84%CE%B1%CF%80%CF%84%CF%85%CF%87%CE%B9%CE%B1%CE%BA%CF%8C&sxsrf=APwXEdeFHTmci0AJLEJ2KwNzOGmHUsRnQg%3A1686922541720&ei=LWWMZOy0K-mRxc8Pn7yt6As&ved=0ahUKEwis__KW9Mf_AhXpSPEDHR9eC70Q4dUDCA8&uact=5&oq=%CE%A3%CF%87%CE%B5%CE%B4%CE%AF%CE%B1%CF%83%CE%B7+%CE%A8%CE%B7%CF%86%CE%B9%CE%B1%CE%BA%CF%8E%CE%BD+%CE%A3%CF%85%CF%83%CF%84%CE%B7%CE%BC%CE%AC%CF%84%CF%89%CE%BD+%CE%BC%CE%B5%CF%84%CE%B1%CF%80%CF%84%CF%85%CF%87%CE%B9%CE%B1%CE%BA%CF%8C&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECCMQJzoKCAAQRxDWBBCwAzoHCCMQsAIQJ0oECEEYAFCSBli8OWC7RWgCcAF4AIABsgGIAZwLkgEEMC4xMJgBAKABAcABAcgBCA&sclient=gws-wiz-serp&bshm=nce/1");
            }
            else if (psyscore >= dysscore && psyscore >= tlesscore)
            {
                label2.Text = "Το υψηλότερο σου σκορ ήταν σην κατεύθυνση Π.Σ.Υ με: " + psyscore + " πόντους.Εμείς προτείνουμε: Αναπτυξη δικτυων.";
                webBrowser1.Navigate("https://www.google.com/search?q=%CE%91%CE%BD%CE%AC%CF%80%CF%84%CF%85%CE%BE%CE%B7+%CE%B4%CE%B9%CE%BA%CF%84%CF%85%CF%89%CE%BD+%CE%BC%CE%B5%CF%84%CE%B1%CF%80%CF%84%CF%85%CF%87%CE%B9%CE%B1%CE%BA%CF%8C&sxsrf=APwXEdfZFAGr1qWBwt4QKp5uGvdfO-D_Cw%3A1686922638335&ei=jmWMZOnwE5W_xc8Pk-KBkAw&ved=0ahUKEwjp7_vE9Mf_AhWVX_EDHRNxAMIQ4dUDCA8&uact=5&oq=%CE%91%CE%BD%CE%AC%CF%80%CF%84%CF%85%CE%BE%CE%B7+%CE%B4%CE%B9%CE%BA%CF%84%CF%85%CF%89%CE%BD+%CE%BC%CE%B5%CF%84%CE%B1%CF%80%CF%84%CF%85%CF%87%CE%B9%CE%B1%CE%BA%CF%8C&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQogQyBQgAEKIEOgoIABBHENYEELADOgsIABCABBCxAxCDAToNCAAQigUQsQMQgwEQQzoGCAAQBxAeOgUIABCABDoTCAAQDRCABBCxAxCDARCxAxCDAToNCAAQDRCABBCxAxCDAToHCAAQDRCABDoICAAQCBAHEB46BAghEApKBAhBGABQtURY1HVgz3doBHABeAGAAcUCiAHjIZIBCDAuMTguNC4xmAEAoAEBwAEByAEI&sclient=gws-wiz-serp&bshm=nce/1");
            }
            else
            {
                label2.Text = "Το υψηλότερο σου σκορ ήταν σην κατεύθυνση Τ.Λ.Ε.Σ με " + tlesscore + " πόντους.Εμεις προτείνουμε: Tεχνολογια αναπτυξη λογισμικου.";
                webBrowser1.Navigate("https://www.google.com/search?q=%CF%84%CE%B5%CF%87%CE%BD%CE%BF%CE%BB%CE%BF%CE%B3%CE%B9%CE%B1+%CE%B1%CE%BD%CE%B1%CF%80%CF%84%CF%85%CE%BE%CE%B7%CF%82+%CE%BC%CE%B5%CF%84%CE%B1%CF%80%CF%84%CF%85%CF%87%CE%B9%CE%B1%CE%BA%CE%BF&sxsrf=APwXEdcDbOr227AIgt3r98zT8vTUmkE-7g%3A1686922703373&ei=z2WMZOeUFqm9xc8Pt7yWuAM&oq=%CE%A4%CE%B5%CF%87%CE%BD%CE%BF%CE%BB%CE%BF%CE%B3%CE%B9%CE%B1+%CE%B1%CE%BD%CE%B1%CF%80%CF%84%CF%85%CE%BE%CE%B7%CF%82+%CE%BC%CE%B5%CF%84%CE%B1%CF%80%CF%84%CF%85%CF%87%CE%B9%CE%B1&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAxgAMgcIIRCgARAKMgcIIRCgARAKMgcIIRCgARAKMgQIIRAVOgcIIxDqAhAnOgQIIxAnOgcIIxCKBRAnOgsIABCABBCxAxCDAToHCAAQigUQQzoLCC4QgwEQsQMQigU6FAguEIAEELEDEIMBEMcBENEDENQCOg0ILhCKBRDHARCvARBDOgoIABCKBRCxAxBDOggIABCABBCxAzoRCC4QgwEQrwEQxwEQsQMQgAQ6BQgAEIAEOgsILhCABBDHARCvAToFCC4QgAQ6BggAEBYQHjoFCCEQoAE6CAghEBYQHhAdSgQIQRgAUABYhyxg2jFoAXABeACAAfgBiAGfKJIBBjAuMjMuNpgBAKABAbABCsABAQ&sclient=gws-wiz-serp&bshm=nce/1");
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mainform form = new mainform();
            form.uname = username;
            form.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PreferenceHelper form = new PreferenceHelper();

            form.Show();
        }
    }
}
