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
    public partial class GetPriceform : Form
    {

        string ordb = "Data source=orcl;User Id=scott; Password=tiger;"; 
        OracleConnection conn;
        public GetPriceform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetMedicicnePrice";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("medicineName", Medicine.Text);
            cmd.Parameters.Add("Mprice", OracleDbType.Double, ParameterDirection.Output);

            try
            {
                cmd.ExecuteNonQuery();
                MedPrice.Text = cmd.Parameters["Mprice"].Value.ToString();
            }
            catch
            {
                MessageBox.Show("No such medicine Found");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
