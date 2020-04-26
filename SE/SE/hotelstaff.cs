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
    public partial class hotelstaff : Form
    {
        public hotelstaff()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            checkbooking f = new checkbooking();
            f.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            bookroomh f = new bookroomh();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            service f = new service();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            adddetail f = new adddetail();
            f.ShowDialog();
        }
    }
}
