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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCeConnection con = new SqlCeConnection("Persist Security Info = False; Data Source =reg_data.sdf;" +
"Password = 'fibo11235813';" +
"Max Database Size = 256; Max Buffer Size = 1024");//connection name

                con.Open();

                SqlCeCommand cmd = new SqlCeCommand("select  Name,ID,email,phone from reg", con);

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
