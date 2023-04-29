using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace Vezeeta
{
    public partial class ReviewsForm : Form
    {
        string ordb = "Data Source=ORCL;User Id=scott;Password=tiger";
        OracleConnection conn;
        public ReviewsForm()
        {
            InitializeComponent();
        }

        private void ReviewsForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

    
        private void ReviewsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void show_review_btn_Click(object sender, EventArgs e)
        {

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetReviews";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Doc_name", DoctorName.Text);
            cmd.Parameters.Add("C_Reviews", OracleDbType.RefCursor, ParameterDirection.Output);


            try
            {
                OracleDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                // Load the data into the DataTable
                dt.Load(dr);

                // Set the DataTable as the data source for the DataGridView
                Reviews.DataSource = dt;

                // Bind the data to the DataGridView
                Reviews.Refresh();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MainForm.instance.Show();
            this.Close();
        }

        private void Reviews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
