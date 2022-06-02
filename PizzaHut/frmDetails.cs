using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaHut
{
    public partial class frmDetails : Form
    {
        public frmDetails()
        {
            InitializeComponent();
        }

        

        private void frmDetails_Load(object sender, EventArgs e)
        {
            txtDetails.Text = frmMain.orderDetails;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDetails_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
