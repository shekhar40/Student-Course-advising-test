using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApplication1
{
    public class DBadapter
    {

       
        public SqlCeConnection sqlCon=null;

        

        public string path;
        
       
        public SqlCeConnection c = null;

        private string connectionString = "";
       
         

    public DBadapter(string dbpath)
    {
        this.path = dbpath;

    }
   
  
    public void InitializeComponent()
    {
       // System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof());
        
    }


   

        public void registration(string a1, string a2, string a3, string a4, string a5)
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
                MessageBox.Show("Connection failed,path : " + path);
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
          

            string sqlquery = ("INSERT INTO reg(Name,ID,pass,email,phone)Values('" + a1 + "','" + a2 + "','" + a3 + "','" + a4 + "','" + a5 + "')");
             Console.WriteLine(sqlquery);
           SqlCeCommand cmd = new SqlCeCommand(sqlquery, sqlCon);
            

            try
            {
                int affectedRows = cmd.ExecuteNonQuery();
               
                if (affectedRows > 0)
                {
                      MessageBox.Show("Registration Successfull !");


                }
               

            }
            catch (Exception)
            {
                MessageBox.Show("Insert Failed.");


            }

            finally
            {

                sqlCon.Close();
            }



        }
     
       

        internal void Show()
        {
            Show();// throw new NotImplementedException();
        }
    }
}
