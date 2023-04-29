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
    public partial class InsertDoctor : Form
    {
        string ordb = "Data Source=ORCL;User Id=hr;Password=hr;";
        OracleConnection conn;
        public static InsertDoctor instance;
        public static int docID = 2;
        public InsertDoctor()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //nthng
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //conn.Dispose();
            //MainForm.instance.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            string ratee = "";
            cmd.Connection = conn;
            cmd.CommandText = "insert into DOCTOR values (:id,:userrr,:pass,:spec,:price,:loc,:phone,:gender,:rate,:mail)";
            cmd.Parameters.Add("id", docID);
            cmd.Parameters.Add("userrr", textBox1.Text);
            cmd.Parameters.Add("pass", textBox2.Text);
            cmd.Parameters.Add("spec", comboBox2.Text);
            cmd.Parameters.Add("price", textBox7.Text);
            cmd.Parameters.Add("loc", textBox6.Text);
            cmd.Parameters.Add("phone", textBox5.Text);
            cmd.Parameters.Add("gender", comboBox1.Text);
            cmd.Parameters.Add("rate", ratee);
            cmd.Parameters.Add("mail", textBox3.Text);

            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("New Doctor is added");
            }
            docID++;
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MainForm.instance.Show();
            this.Close();
        }
    }
}
