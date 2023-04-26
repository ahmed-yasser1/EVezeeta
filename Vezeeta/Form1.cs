using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vezeeta
{
    public partial class Form1 : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
   
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {



            string connection_str = "Data Source=orcl; User Id=hr;Password=hr";
            string command_str = "select speciality from doctor";

            adapter = new OracleDataAdapter(command_str, connection_str);
            DataSet ds_Speciality = new DataSet();
            adapter.Fill(ds_Speciality);


            for (int intCount = 0; intCount < ds_Speciality.Tables[0].Rows.Count; intCount++)
            {
                var val = ds_Speciality.Tables[0].Rows[intCount]["speciality"].ToString();

                //check if it already exists
                if (! cmb1.Items.Contains(val))
                {
                    cmb1.Items.Add(val);
                }
            }

   




        }

        private void grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connection_str = "Data Source=orcl; User Id=hr;Password=hr";
            string command_str = "select * from doctor where speciality  =:spec";

            adapter = new OracleDataAdapter(command_str, connection_str);
            adapter.SelectCommand.Parameters.Add("spec", cmb1.SelectedItem.ToString());
            DataSet ds_Selected = new DataSet();
            adapter.Fill(ds_Selected);
            grid1.DataSource = ds_Selected.Tables[0];
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }
    }
}
