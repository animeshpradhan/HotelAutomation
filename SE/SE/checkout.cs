using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SE
{
    public partial class checkout : Form
    {
        public checkout()
        {
            InitializeComponent();
        }
        public static int x;
        int flag = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource= localhost; port = 3306; username = root; password = animesh1!";
            string q1 = "select * from userreg.registration where idregistration = '" + this.textBox1.Text + "'  and password= '" + this.textBox2.Text + "'; ";
            string q2 = "select idregistration from userreg.registration where idregistration = '" + this.textBox1.Text + "'  and password= '" + this.textBox2.Text + "'; ";
            MySqlDataReader myReader;

            using (MySqlConnection myConn = new MySqlConnection(myConnection))
            {
                myConn.Open();
                using (MySqlCommand command1 = new MySqlCommand(q1, myConn))
                {
                    try
                    {
                        myReader = command1.ExecuteReader();
                        int count = 0;
                        while (myReader.Read())
                        {
                            count = count + 1;
                        }
                        if (count == 1)
                        {
                            MessageBox.Show("Username and Password is correct");
                           
                            flag = 1;


                        }
                        else if (count > 1)
                        {
                            MessageBox.Show("Duplicate...Access Denied");

                        }
                        else
                        {
                            //string msg = count.ToString();
                            MessageBox.Show("Incorrect Username and Password");

                        }
                        myReader.Close();


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    using (MySqlCommand command2 = new MySqlCommand(q2, myConn))
                    {
                        try
                        {
                            x = Convert.ToInt32(command2.ExecuteScalar());
                            
                           // MessageBox.Show("ID: " + x1);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                    }

                }
                if(flag==1)
                {
                    string x1 = x.ToString();
                    //MessageBox.Show("ID: " + x1);
                    this.Hide();
                    bill f = new bill();
                    f.ShowDialog();
                }
            }
            }
    }
}
