using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        public string path;

        private void button2_Click(object sender, EventArgs e)
        {
            reg f = new reg();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string id = "";
            using (SqlCeConnection dataConnection = new SqlCeConnection(@"Persist Security Info = False; Data Source = reg_data.sdf;" +
"Password = 'fibo11235813';" +
"Max Database Size = 256; Max Buffer Size = 1024"))
            using (SqlCeCommand dataCommand =
                    new SqlCeCommand("select ID from reg where pass='" + textBox2.Text + "'", dataConnection))
            {

                dataConnection.Open();
                id = Convert.ToString(dataCommand.ExecuteScalar());
            }
            if (id == textBox1.Text && t1.Text == "Teacher" && textBox2.Text == "123")
            {
                Teacher h = new Teacher();
                h.Show();
                this.Hide();
            }
            else if (t1.Text == "Student" && id ==textBox1.Text)
            {
                Student s = new Student();
                this.Hide();
                s.Show();
                }
            else
            {
                MessageBox.Show("failed !!! try Again");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            t1.Text = "Student";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            t1.Text = "Teacher";
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
