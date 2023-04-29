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


        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select booking_date from appointments ap,doctor d where d.user_name=:doc_name and d.doctor_id= ap.doctor_id and booking_date >= Sysdate";
            cmd.Parameters.Add("doc_name", Doc_name.Text);
          

            //try
            //{
                OracleDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                // Load the data into the DataTable
                dt.Load(dr);

                // Set the DataTable as the data source for the DataGridView
                dataGridView1.DataSource = dt;

                // Bind the data to the DataGridView
                dataGridView1.Refresh();


           // }

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());

            //}
        }

   

        private void Form3_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            //conn.Dispose();
            //MainForm.instance.Close();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MainForm.instance.Show();
            this.Close();
        }
    }
}
