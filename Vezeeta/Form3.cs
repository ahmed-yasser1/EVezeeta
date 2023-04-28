using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace Vezeeta
{
    public partial class Form3 : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;"; 
        OracleConnection conn;
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select booking_date from appointments ap,doctor d where d.user_name=:doc_name and d.doctor_id= ap.doctor_id and booking_date >= Sysdate";
            cmd.Parameters.Add("doc_name", Doc_name.Text);
            //cmd.Parameters.Add("dateTime", OracleDbType.TimeStamp).Value = DateTime.Now;

            try
            {
                OracleDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                // Load the data into the DataTable
                dt.Load(dr);

                // Set the DataTable as the data source for the DataGridView
                dataGridView1.DataSource = dt;

                // Bind the data to the DataGridView
                dataGridView1.Refresh();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void Doc_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
