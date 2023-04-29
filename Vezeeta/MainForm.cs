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
    
    public partial class MainForm : Form
    {
        public static MainForm instance;
        public MainForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertDoctor form = new InsertDoctor();
            form.Show();
            instance.Hide();
            //form1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertPatient form3 = new InsertPatient();
            form3.Show();
            instance.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form4 = new Form1();
            form4.Show();
            instance.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReviewsForm reviewsForm = new ReviewsForm();
            reviewsForm.Show();
            instance.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            instance.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GetPriceform getPriceform = new GetPriceform();
            getPriceform.Show();
            instance.Hide();
        }

        private void Med_Report_Click(object sender, EventArgs e)
        {
            medicineReportForm medform = new medicineReportForm();
            medform.Show();
            instance.Hide();
        }

        private void Phy_Report_Click(object sender, EventArgs e)
        {
            Form4 phform = new Form4();
            phform.Show();
            instance.Hide();
        }
    }
}
