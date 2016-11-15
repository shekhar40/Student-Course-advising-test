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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string dbpath = "";
        public string dbfilename = "";

        private void button1_Click(object sender, EventArgs e)
        {
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult result = dialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Current database directory: " + dialog.SelectedPath.ToString());
                dbpath = dialog.SelectedPath.ToString();
            }
            /*if (File.Exists("C:\\Users\\Sajid\\Documents\\ego.sdf"))
                File.Delete("C:\\Users\\Sajid\\Documents\\ego.sdf");*/

            if (!String.IsNullOrEmpty(dbpath))
            {

                if (File.Exists(dbpath + "\\" + textBox2.Text + ".sdf"))
                    File.Delete(dbpath + "\\" + textBox2.Text + ".sdf");

                dbfilename = dbpath + "\\" + textBox2.Text + ".sdf";
                Console.WriteLine(dbfilename);
                string connStr = "Data Source = " + dbpath + "\\" + textBox2.Text + ".sdf; Password = 'fibo11235813';";

                SqlCeEngine engine = new SqlCeEngine(connStr);
                engine.CreateDatabase();
                engine.Dispose();
                SqlCeConnection conn = null;

                try
                {
                    conn = new SqlCeConnection(connStr);
                    conn.Open();

                    SqlCeCommand cmd = conn.CreateCommand();
                    SqlCeCommand cmd1 = conn.CreateCommand();
                    SqlCeCommand cmd2 = conn.CreateCommand();
                   
                    
                    cmd.CommandText = "CREATE TABLE reg(ID nvarchar(300),pass nvarchar(300),Name nvarchar(300),email nvarchar(300),gender nvarchar(300),Phone nvarchar(300),DATE nvarchar(300));";
                    cmd1.CommandText = "CREATE TABLE stu(ID nvarchar(300),s1 nvarchar(300),s2 nvarchar(300),s3 nvarchar(300),s4 nvarchar(300),Approved nvarchar(300),DATE nvarchar(300));";
                    cmd2.CommandText = "CREATE TABLE tea(ID nvarchar(300),s1 nvarchar(300),s2 nvarchar(300),s3 nvarchar(300),s4 nvarchar(300),Approved nvarchar(300),Not_Approved nvarchar(300),DATE nvarchar(300));";
                   
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                   
                    MessageBox.Show("Database created :" + textBox2.Text);
                    this.Close();
                }

                catch
                {
                    Console.WriteLine("hello\n");

                }

                finally
                {
                    conn.Close();
                }

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
