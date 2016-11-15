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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login f = new login();
            f.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id ="";
              using (SqlCeConnection dataConnection = new SqlCeConnection(@"Persist Security Info = False; Data Source = reg_data.sdf;" +
"Password = 'fibo11235813';" +
"Max Database Size = 256; Max Buffer Size = 1024"))
            using (SqlCeCommand dataCommand =
                    new SqlCeCommand("select ID from reg where pass='" + textBox2.Text + "'", dataConnection))
            {

                dataConnection.Open();
                id = Convert.ToString(dataCommand.ExecuteScalar());
            }
              if (t1.Text == id)
              {
                  string connectionString = "Persist Security Info = False; Data Source = reg_data.sdf;" +
      "Password = 'fibo11235813';" +
      "Max Database Size = 256; Max Buffer Size = 1024";

                  SqlCeConnection sqlCon = new SqlCeConnection(connectionString);

                  try
                  {
                      sqlCon.Open();
                  }
                  catch (SqlCeException ex)
                  {

                  }

                  string a1 = "CSE 101";
                  string sqlquery = ("INSERT INTO stu(ID,s1)Values('" + t1.Text + "','" + a1 + "')");
                  Console.WriteLine(sqlquery);
                  SqlCeCommand cmd = new SqlCeCommand(sqlquery, sqlCon);


                  try
                  {
                      int affectedRows = cmd.ExecuteNonQuery();

                      if (affectedRows > 0)
                      {
                          MessageBox.Show("Subject Taken");


                      }


                  }
                  catch (Exception)
                  {
                      MessageBox.Show("Shomvob na vai");


                  }

                  finally
                  {

                      sqlCon.Close();
                  }
              }
              else
              {
                  MessageBox.Show("ID is invalid");
              }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "Persist Security Info = False; Data Source = reg_data.sdf;" +
"Password = 'fibo11235813';" +
"Max Database Size = 256; Max Buffer Size = 1024";

            SqlCeConnection sqlCon = new SqlCeConnection(connectionString);

            try
            {
                sqlCon.Open();
            }
            catch (SqlCeException ex)
            {
               
            }

            string a1 = "CSE 109";
            string sqlquery = ("INSERT INTO stu(ID,s2)Values('" + t1.Text + "','" + a1 + "')");
            Console.WriteLine(sqlquery);
            SqlCeCommand cmd = new SqlCeCommand(sqlquery, sqlCon);


            try
            {
                int affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Subject Taken");


                }


            }
            catch (Exception)
            {
                MessageBox.Show("Shomvob na vai");


            }

            finally
            {

                sqlCon.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "Persist Security Info = False; Data Source = reg_data.sdf;" +
"Password = 'fibo11235813';" +
"Max Database Size = 256; Max Buffer Size = 1024";

            SqlCeConnection sqlCon = new SqlCeConnection(connectionString);

            try
            {
                sqlCon.Open();
            }
            catch (SqlCeException ex)
            {
              
            }

            string a1 = "CSE 107";
            string sqlquery = ("INSERT INTO stu(ID,s3)Values('" + t1.Text + "','" + a1 + "')");
            Console.WriteLine(sqlquery);
            SqlCeCommand cmd = new SqlCeCommand(sqlquery, sqlCon);


            try
            {
                int affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Subject Taken");


                }


            }
            catch (Exception)
            {
                MessageBox.Show("Shomvob na vai");


            }

            finally
            {

                sqlCon.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionString = "Persist Security Info = False; Data Source = reg_data.sdf;" +
"Password = 'fibo11235813';" +
"Max Database Size = 256; Max Buffer Size = 1024";

            SqlCeConnection sqlCon = new SqlCeConnection(connectionString);

            try
            {
                sqlCon.Open();
            }
            catch (SqlCeException ex)
            {
                
            }

            string a1 = "CSE 102";
            string sqlquery = ("INSERT INTO stu(ID,s4)Values('" + t1.Text + "','" + a1 + "')");
            Console.WriteLine(sqlquery);
            SqlCeCommand cmd = new SqlCeCommand(sqlquery, sqlCon);


            try
            {
                int affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Subject Taken");


                }


            }
            catch (Exception)
            {
                MessageBox.Show("Shomvob na vai");


            }

            finally
            {

                sqlCon.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCeConnection con = new SqlCeConnection("Persist Security Info = False; Data Source =reg_data.sdf;" +
"Password = 'fibo11235813';" +
"Max Database Size = 256; Max Buffer Size = 1024");//connection name

                con.Open();

                SqlCeCommand cmd = new SqlCeCommand("select * from reg", con);

                cmd.CommandType = CommandType.Text;

                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds, "ss");

                datasource.DataSource = ds.Tables["ss"];



            }

            catch
            {

                MessageBox.Show("No Record Found");

            }
        }

        private void datasource_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
