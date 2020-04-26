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
    public partial class bookroom : Form
    {
        public bookroom()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string q1;
            string q2;
            string q3;
            string q4 = "select no FROM userreg.registration where idregistration = '"+ this.textBox1.Text+"'";
            string q5 = "update userreg.registration set no = @id where idregistration = '" + this.textBox1.Text + "'";
            int flag = 0;
            int num = 0;
            if(comboBox1.Text == "Single" && comboBox2.Text == "AC")
            {
                 q1 = "select * from room.roomdetail where single = 1 and ac = 1 and occupied = 0 ; ";
                q3 = "select roomno from room.roomdetail where single = 1 and ac = 1 and occupied =0;";
                 q2 = "update room.roomdetail set occupied= 1, userid='" + this.textBox1.Text + "' where single = 1 and ac = 1  LIMIT 1";
                flag = 2;
            }
            else if(comboBox1.Text == "Single" && comboBox2.Text == "Non-AC")
            {
                flag = 1;
                 q1 = "select * from room.roomdetail where single = 1 and ac = 0 and occupied = 0 ; ";
                q3 = "select roomno from room.roomdetail where single = 1 and ac = 0 and occupied =0;";
                q2 = "update room.roomdetail set occupied= 1, userid='" + this.textBox1.Text + "' where single = 1 and ac = 0  and occupied = 0 LIMIT 1";
            }
            else if(comboBox1.Text == "Double" && comboBox2.Text == "Non-AC")
            {
                flag = 3;
                 q1 = "select * from room.roomdetail where single = 0 and ac = 0 and occupied = 0 ; ";
                q3 = "select roomno from room.roomdetail where single = 0 and ac = 0 and occupied =0;";
                q2 = "update room.roomdetail set occupied= 1, userid='" + this.textBox1.Text + "' where single = 0 and ac = 0 and occupied = 0 LIMIT 1";
            }
            else
            {
                flag = 4;
                 q1 = "select * from room.roomdetail where single = 0 and ac = 1 and occupied = 0 ; ";
                q3 = "select roomno from room.roomdetail where single = 0 and ac = 1 and occupied =0;";
                q2 = "update room.roomdetail set occupied= 1, userid='" + this.textBox1.Text + "' where single = 0 and ac = 1 and occupied = 0  LIMIT 1";
            }

            string myConnection = "datasource= localhost; port = 3306; username = root; password = animesh1!";
            
            
            MySqlDataReader myReader;
            MySqlDataReader myReader1;
            MySqlDataReader myReader2;
            using (MySqlConnection myConn = new MySqlConnection(myConnection))
            {
                myConn.Open();
                int count = 0 ;
                using (MySqlCommand command1 = new MySqlCommand(q1, myConn))
                {
                    try
                    {
                        myReader = command1.ExecuteReader();
                         
                        while (myReader.Read())
                        {
                            count = count + 1;
                        }
                        myReader.Close();
                        if (count >= 1)
                        {
                            string m = count.ToString();
                            MessageBox.Show("Room Available");  


                        }
                       
                        else
                        {
                            //string msg = count.ToString();
                            MessageBox.Show("We are Sorry! \n Preferred Room Not Available \n Kindly Check Something Else");

                        }
                        


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    if (count >= 1)
                    {
                        using (MySqlCommand command2 = new MySqlCommand(q3, myConn))
                        {
                            try
                            {
                                int x = Convert.ToInt32(command2.ExecuteScalar());
                                string x1 = x.ToString();
                                string msg = "Room Booking Successful. \n Your Room No: " + x1;
                                MessageBox.Show(msg);
                            }
                            catch (Exception ex2)
                            {

                                MessageBox.Show(ex2.Message);
                            }
                        }

                        using (MySqlCommand command3 = new MySqlCommand(q2, myConn))
                        {
                            try
                            {

                                myReader1 = command3.ExecuteReader();
                                //MessageBox.Show("Successful Update");
                                while (myReader1.Read())
                                {

                                }
                                myReader1.Close();
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);
                            }
                        }
                        using (MySqlCommand command4 = new MySqlCommand(q4, myConn))
                        {
                            try
                            {

                                num = Convert.ToInt32(command4.ExecuteScalar());
                                num = num + flag;
                                
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);
                            }
                        }
                        using (MySqlCommand command5 = new MySqlCommand(q5, myConn))
                        {
                            try
                            {

                                command5.Parameters.AddWithValue("@id", num);
                                myReader2 = command5.ExecuteReader();
                                //MessageBox.Show("Successful Update");
                                while (myReader2.Read())
                                {

                                }
                                myReader2.Close();
                                string x1 = num.ToString();
                                string msg = "Score Collected " + x1;
                                MessageBox.Show(msg);

                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);
                            }
                        }
                    }

                }
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            customer f = new customer();
            f.ShowDialog();
        }
    }
}
