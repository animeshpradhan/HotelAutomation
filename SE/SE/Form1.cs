using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
namespace SE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string myConnection = "datasource= localhost; port = 3306; username = root; password = animesh1!";
            string q1 = "select * from userreg.registration where username = '" + this.username_txt.Text + "'  and password= '" + this.password_txt.Text + "'; ";
            string q2 = "select usertype from userreg.registration where username ='" + this.username_txt.Text + "' and password= '" + this.password_txt.Text + "'; ";
            string q3 = "select idregistration from userreg.registration where username = '" + this.username_txt.Text + "' and password = '" + this.password_txt.Text + "'; ";
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
                }
                using (MySqlCommand command3 = new MySqlCommand(q3, myConn))
                {
                    try
                    {

                    }
                    catch (Exception ex2)
                    {

                        MessageBox.Show(ex2.Message);
                    }
                }
                using (MySqlCommand command2 = new MySqlCommand(q2, myConn))
                {
                    try
                    {
                        string x = Convert.ToString(command2.ExecuteScalar());
                        if(x=="Customer")
                        {
                            this.Hide();
                            customer f = new customer();
                            f.ShowDialog();
                        }
                        else if(x=="Hotel Staff")
                        {
                            this.Hide();
                            hotelstaff f = new hotelstaff();
                            f.ShowDialog();
                        }
                        else if(x=="Admin")
                        {
                            this.Hide();
                            admin f = new admin();
                            f.ShowDialog();
                        }
                    }
                    catch (Exception ex1)
                    {

                        MessageBox.Show(ex1.Message);
                    }
                }


            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
