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

namespace Vezeeta
{


    public partial class Form2 : Form
    {
        OracleCommandBuilder builder;
        OracleDataAdapter adapter;
        DataSet ds;



        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {

            string connStr = "Data Source=orcl; User Id=hr;Password=hr";
            string cmdStr = "select * from doctor where doctor_id  =:id";

            adapter = new OracleDataAdapter(cmdStr, connStr);

            adapter.SelectCommand.Parameters.Add("id", tbox1.Text);

            ds = new DataSet();

            adapter.Fill(ds);

            grid1.DataSource = ds.Tables[0];
            //int.Parse(tbox1.Text)
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // Create a new instance of the previous form
            this.Hide();
            form1.Show(); // Show the previous form
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            
        }

        private void grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
