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
    public partial class adddetail : Form
    {
        public adddetail()
        {
            InitializeComponent();
            fillcombo();
        }

        void fillcombo()
        {
            string constring = "datasource= localhost; port = 3306; username = root; password = animesh1!";

            string Query = "select *from room.roomdetail";
            
            MySqlDataReader myReader;
            using (MySqlConnection connection = new MySqlConnection(constring))
            {
                connection.Open();
                using (MySqlCommand command1 = new MySqlCommand(Query, connection))
                {
                    try
                    {

                        myReader = command1.ExecuteReader();
                        
                        while (myReader.Read())
                        {
                            string sname = myReader.GetString("roomno");
                            comboBox8.Items.Add(sname);
                        }
                        myReader.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
            }
        
    }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource= localhost; port = 3306; username = root; password = animesh1!";

            string Query = "insert into detail.adddetail (userid,roomno,arrivaldate,arrivalmonth,arrivalyear,departuredate,departuremonth,departureyear,no,price) values ('" + this.textBox1.Text + "', '" + this.comboBox8.Text + "', '" + this.comboBox1.Text + "','" + this.comboBox2.Text + "', '" + this.comboBox3.Text + "','" + this.comboBox4.Text + "','" + this.comboBox5.Text + "','" + this.comboBox6.Text + "','" + this.comboBox7.Text + "' ,@pr);";
            string q = "select * from detail.adddetail where userid ='" + this.textBox1.Text + "' and roomno= '" + this.comboBox8.Text + "'; ";
            // MySqlConnection conDataBase = new MySqlConnection(constring);
            //MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            string str = comboBox8.Text;
            int x1 = Int32.Parse(str);
            int ro;
            string q1 = "select price from room.roomdetail where roomno = '"+ comboBox8.Text+"'";
            string noroom = comboBox7.Text;
            int nro = Int32.Parse(noroom); 
            int x;
            int pri=0;
            MySqlDataReader myReader;
            MySqlDataReader myReader2;
            int count = 0;
            using (MySqlConnection connection = new MySqlConnection(constring))
            {
                connection.Open();
                using (MySqlCommand command3 = new MySqlCommand(q1, connection))
                {
                    try
                    {
                        //command3.Parameters.AddWithValue("@ro", x1);
                        x = Convert.ToInt32(command3.ExecuteScalar());
                        pri = x * nro;
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
                using (MySqlCommand command1 = new MySqlCommand(q, connection))
                {
                    try
                    {

                        myReader = command1.ExecuteReader();
                       // MessageBox.Show("Information Added");
                        while (myReader.Read())
                        {
                            count = count + 1;
                        }
                        myReader.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
                if (count == 0)
                {
                    using (MySqlCommand command2 = new MySqlCommand(Query, connection))
                    {
                        try
                        {
                            command2.Parameters.AddWithValue("@pr", pri);
                            myReader2 = command2.ExecuteReader();
                            MessageBox.Show("Information Added");
                            while (myReader2.Read())
                            {

                            }
                            myReader2.Close();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("This information was already added");
                }
                
                
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            string constring = "datasource= localhost; port = 3306; username = root; password = animesh1!";

            string Query = "select roomno from room.roomdetail where userid = '" + this.textBox1.Text + "' ";

            MySqlDataReader myReader;
            using (MySqlConnection connection = new MySqlConnection(constring))
            {
                connection.Open();
                using (MySqlCommand command1 = new MySqlCommand(Query, connection))
                {
                    try
                    {

                        myReader = command1.ExecuteReader();
                        string values = "";
                        if (myReader.HasRows)
                        {
                            while (myReader.Read())
                            {
                                values = values + myReader[0].ToString();
                            }
                            MessageBox.Show("The rooms currently booked by the user-id: " + values);
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

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            hotelstaff f = new hotelstaff();
            f.ShowDialog();
        }
    }
}
