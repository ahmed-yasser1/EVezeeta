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
    public partial class InsertPatient : Form
    {
        string ordb = "Data Source=ORCL;User Id=hr;Password=hr;";
        OracleConnection conn;
        public static InsertPatient instance;
        public static int patID = 2;
        public InsertPatient()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            //conn.Dispose();
            //MainForm.instance.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into PATIENT values (:id,:userrr,:pass,:phone,:gender,:birth,:insurance,:mail)";
            cmd.Parameters.Add("id", patID);
            cmd.Parameters.Add("userrr", textBox1.Text);
            cmd.Parameters.Add("pass", textBox2.Text);
            cmd.Parameters.Add("phone", textBox5.Text);
            cmd.Parameters.Add("gender", comboBox1.Text);
            cmd.Parameters.Add("birth", textBox6.Text);
            cmd.Parameters.Add("insurance", textBox7.Text);
            cmd.Parameters.Add("mail", textBox3.Text);

            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("New Patient is added");
            }
            patID++;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MainForm.instance.Show();
            this.Close();
        }
    }
}
