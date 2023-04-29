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
    public partial class Form4 : Form
    {
        CrystalReport1 CRV;
        public Form4()
        {
            InitializeComponent();
        }

        private void CR_VIWER_Load(object sender, EventArgs e)
        {
            CRV = new CrystalReport1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CR_VIWER.ReportSource = CRV;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainForm.instance.Show();
            this.Close();
        }
    }
}
