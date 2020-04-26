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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource= localhost; port = 3306; username = root; password = animesh1!";
            
            string Query = "insert into userreg.registration (username, usertype, phoneno, city, email, password) values ('" + this.name_txt.Text + "', '" + this.userType_txt.Text + "', '" + this.phoneNo_txt.Text + "','" + this.city_txt.Text + "', '" + this.email_txt.Text + "','" + this.password_txt.Text + "' );";
            string q = "SELECT max(idregistration) FROM userreg.registration";
           // MySqlConnection conDataBase = new MySqlConnection(constring);
            //MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            using (MySqlConnection connection = new MySqlConnection(constring))
            {
                connection.Open();
                using (MySqlCommand command1 = new MySqlCommand(Query, connection))
                {
                    try
                    {
                        
                        myReader = command1.ExecuteReader();
                        //MessageBox.Show("Successful Sign-Up");
                        while (myReader.Read())
                        {

                        }
                        myReader.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    
                }
                using (MySqlCommand command2 = new MySqlCommand(q, connection))
                {
                    try
                    {
                        
                        int x = Convert.ToInt32(command2.ExecuteScalar());
                        string x1 = x.ToString();
                        string msg = "Sign-Up Successful. \n Your UserID: " + x1;
                        MessageBox.Show(msg);
                    }
                    catch (Exception ex1)
                    {

                        MessageBox.Show(ex1.Message);
                    }
                }
                // etc
            }


           
                
                

                
                
               
               
                
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string constring = "datasource= localhost; port = 3306; username = root; password = animesh1!";

            string Query = "update userreg.registration set username='" + this.name_txt.Text + "',usertype= '" + this.userType_txt.Text + "', phoneno='" + this.phoneNo_txt.Text + "',city='" + this.city_txt + "', email='" + this.email_txt.Text + "',password='" + this.password_txt.Text + "' where username='" + this.name_txt.Text+"'; ";
            
            // MySqlConnection conDataBase = new MySqlConnection(constring);
            //MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            using (MySqlConnection connection = new MySqlConnection(constring))
            {
                connection.Open();
                using (MySqlCommand command1 = new MySqlCommand(Query, connection))
                {
                    try
                    {

                        myReader = command1.ExecuteReader();
                        MessageBox.Show("Successful Update");
                        while (myReader.Read())
                        {

                        }
                        myReader.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
                
                // etc
            }

        }
    }
}
 