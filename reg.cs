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
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();
        }
        public string path;
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login n = new login();
            n.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBadapter db = new DBadapter(path);
            db.registration(t1.Text,t2.Text,t3.Text,t4.Text,t5.Text);
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void dataToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 hj = new Form2();
            hj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCeConnection con = new SqlCeConnection("Persist Security Info = False; Data Source =reg_data.sdf;" +
"Password = 'fibo11235813';" +
"Max Database Size = 256; Max Buffer Size = 1024");//connection name

                con.Open();

                SqlCeCommand cmd = new SqlCeCommand("select  * from stu", con);

                cmd.CommandType = CommandType.Text;

                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds, "ss");

                dataGridView1.DataSource = ds.Tables["ss"]; ;

               

            }

            catch
            {

                MessageBox.Show("No Record Found");

            }
        }
    }
}
