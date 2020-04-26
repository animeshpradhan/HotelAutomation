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
    public partial class checkbooking : Form
    {
        public checkbooking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource= localhost; port = 3306; username = root; password = animesh1!";

            string Query = "select roomno from room.roomdetail where userid = '" + this.textBox1.Text + "';";
            
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
                                values = values + myReader[0].ToString()+ "  ";
                            }
                            MessageBox.Show("The rooms currently booked by the user-id: " + values + " ");
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            hotelstaff f = new hotelstaff();
            f.ShowDialog();
        }
    }
}
