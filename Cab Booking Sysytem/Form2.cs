using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Vehicle_investigation_system
{
    public partial class Form2 : Form
    {

        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            con.ConnectionString = "PROVIDER=MSDAORA; USER ID=system; PASSWORD=12345; Unicode=true;";
            try
            { 
                con.Open();
                if (Convert.ToBoolean(con.State))
                {
                      MessageBox.Show("Connection Success");
                }
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }
            
        }

      private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VEHICLE_TextChanged(object sender, EventArgs e)
        {

        }

        private void SUBMIT_Click(object sender, EventArgs e)
        {

            if (VEHICLE.Text != "" & WHEELER.Text != "" & TYPE.Text != "" & CHECHIS.Text != "" & NAME.Text != "" & RELATION.Text != "" & ID.Text != "" & MOB.Text != "" & ADDR.Text != "")
            {

                com.Connection = con;
                com.CommandText = "insert into registration(vehicle,wheeler,type,chechis,name,relation,id,mob,addr) values ('" + VEHICLE.Text + "','" + WHEELER.Text + "','" + TYPE.Text + "','" + CHECHIS.Text + "','" + NAME.Text + "','" + RELATION.Text + "','" + ID.Text + "','" + MOB.Text + "','" + ADDR.Text + "')";
                com.ExecuteNonQuery();
                com.Dispose();
                MessageBox.Show("record inserted");
            }
            else
            {
                MessageBox.Show("Plzzz insert all entries ");
            }
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void RNO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
