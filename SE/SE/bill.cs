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
    public partial class bill : Form
    {
        public bill()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = checkout.x;
            //string x1 = checkout.x.ToString();
            //textBox1.Text = x1;
            string constring = "datasource= localhost; port = 3306; username = root; password = animesh1!";
            string Query = "select *from detail.adddetail where userid  = @id";
            string Query1 = "select *from service.servicedetail where userid  = @id";
            string Query2 = "select price from detail.adddetail where userid  = @id";
            string Query3 = "select cost from service.servicedetail where userid  = @id"; 
            string Query4 = "DELETE FROM detail.adddetail WHERE userid = @id";
            string q = "select no from userreg.registration where idregistration = @id";
            MySqlDataReader myReader;
            MySqlDataReader myReader1;
            int v = 0;
            int v1 = 0;
            int dis = 0;
            int total = 0;
            using (MySqlConnection connection = new MySqlConnection(constring))
            {
                connection.Open();

                
                using (MySqlCommand command1 = new MySqlCommand(Query, connection))
                {

                    command1.Parameters.AddWithValue("@id", id);
                    MySqlDataAdapter sda = new MySqlDataAdapter(command1);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                    dataGridView1.DataSource = dt; //give your gridview name here
                    //dataGridView1.DataBindings();//give your gridview name here
                    
                }
                using (MySqlCommand command2 = new MySqlCommand(Query1, connection))
                {

                    command2.Parameters.AddWithValue("@id", id);
                    MySqlDataAdapter sda = new MySqlDataAdapter(command2);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView2.DataSource = dt; //give your gridview name here
                                                   //dataGridView1.DataBindings();//give your gridview name here

                }
                using (MySqlCommand command3 = new MySqlCommand(Query2, connection))
                {

                    try
                    {
                        command3.Parameters.AddWithValue("@id", id);
                        myReader = command3.ExecuteReader();
                        string values = "";
                        
                        if (myReader.HasRows)
                        {
                            while (myReader.Read())
                            {
                                values = myReader[0].ToString();
                                int s = Int32.Parse(values);
                                v = v + s;
                            }
                            //MessageBox.Show("The rooms currently booked by the user-id: " + values + " ");
                            string roomc = v.ToString();
                            textBox1.Text = roomc;
                        }
                        else
                        {
                            MessageBox.Show("No Rooms Booked by this User");
                        }
                        myReader.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
                using (MySqlCommand command4 = new MySqlCommand(Query3, connection))
                {

                    try
                    {
                        command4.Parameters.AddWithValue("@id", id);
                        myReader1 = command4.ExecuteReader();
                        string values = "";

                        if (myReader1.HasRows)
                        {
                            while (myReader1.Read())
                            {
                                values = myReader1[0].ToString();
                                int s = Int32.Parse(values);
                                v1 = v1 + s;
                            }
                            //MessageBox.Show("The rooms currently booked by the user-id: " + values + " ");
                            
                        }
                        
                        else
                        {
                           // MessageBox.Show("No Rooms Booked by this User");
                        }
                        string roomc = v1.ToString();
                        textBox2.Text = roomc;
                        myReader1.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
                using (MySqlCommand command5 = new MySqlCommand(q, connection))
                {
                    try
                    {
                        command5.Parameters.AddWithValue("@id", id);
                        int fr = Convert.ToInt32(command5.ExecuteScalar());
                        if(fr>50 && fr<=60)
                        {
                            dis = 3;
                            total =(int) 0.03 * (v + v1);
                        }
                        else if(fr>60 && fr<=75)
                        {
                            dis = 5;
                            total = (int)0.05 * (v + v1);
                        }
                        else if(fr>75)
                        {
                            dis = 10;
                            total = (int)0.1 * (v + v1);

                        }
                        else
                        {
                            total = v + v1;
                        }

                        string s1 = dis.ToString();
                        string t1 = total.ToString();
                        textBox3.Text = s1 + "%";
                        textBox4.Text = t1;
                        //string msg = "Sign-Up Successful. \n Your UserID: " + x1;
                        //MessageBox.Show(msg);
                    }
                    catch (Exception ex1)
                    {

                        MessageBox.Show(ex1.Message);
                    }
                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = checkout.x;
            string constring = "datasource= localhost; port = 3306; username = root; password = animesh1!";
            string Query = "delete from detail.adddetail where userid = @id";
            string Query1 = "delete from service.servicedetail where userid = @id";
            string Query2 = "update room.roomdetail set occupied = 0, userid =0 where userid = @id";
            using (MySqlConnection connection = new MySqlConnection(constring))
            {
                connection.Open();


                using (MySqlCommand command1 = new MySqlCommand(Query, connection))
                {
                    try
                    {
                        command1.Parameters.AddWithValue("@id", id);
                        command1.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
                using (MySqlCommand command2 = new MySqlCommand(Query1, connection))
                {
                    try
                    {
                        command2.Parameters.AddWithValue("@id", id);
                        command2.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
                using (MySqlCommand command3 = new MySqlCommand(Query2, connection))
                {
                    try
                    {
                        command3.Parameters.AddWithValue("@id", id);
                        command3.ExecuteNonQuery();
                        MessageBox.Show("Thank you for believing on us. \n Hope you had a comfortable stay.");
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
