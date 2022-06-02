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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        CheckBox[] toppings = new CheckBox[6];

        string size = "";
        string crust = "";
        string eat = "";
        string category = "";
        string choice = "";

        public static string orderDetails = "";

        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Add("Classic");
            cmbCategory.Items.Add("Signature");
            cmbCategory.Items.Add("Favourite");
            cmbCategory.Items.Add("Supreme");
            cmbCategory.SelectedIndex = 0;

            toppings[0] = chkCheese;
            toppings[1] = chkMushrooms;
            toppings[2] = chkBlack;
            toppings[3] = chkOnions;
            toppings[4] = chkPeppers;
            toppings[5] = chkTomatoes;

            rdoSmall.Checked = true;
            rdoThin.Checked = true;
            rdoEatIn.Checked = true;            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            string toppingList = "";
            int topcount = 0;

            for (int i = 0; i < toppings.Length; i++)
            {
                if (toppings[i].Checked)
                {
                    toppingList += toppings[i].Text + " ";
                    topcount++;
                }
            }

            string msg = "******* Your Pizza *******";

            msg += "\n";
            msg += "\nCategory: " + category;
            msg += "\nChoice: " + choice;
            msg += "\nSize: " + size;
            msg += "\nCrust: " + crust;
            msg += "\nToppings: " + toppingList;
            msg += "\nWhere to Eat: " + eat;

            double catcost = 0;
            double service = 0;
            double topcost = topcount * 20; ;
            double totalcost = 0;

            double sizeT = 0;
            if(size=="Small")
            {
                sizeT = 1;
            }
            else if(size == "Medium")
            {
                sizeT = 1.2;
            }
            else if(size == "Large")
            {
                sizeT = 1.4;
            }


            if(category== "Classic")
            {
                catcost = 620;
            }
            else if(category == "Signature")
            {
                catcost = 680;
            }
            else if(category == "Favourite")
            {
                catcost = 750;
            }
            else if (category == "Supreme")
            {
                catcost = 930;
            }

            if(eat=="Deliver")
            {
                service = 100;
            }
            else if(eat=="Park and Pick")
            {
                service = 50;
            }

            totalcost = (catcost * sizeT) + service;

            msg += "\nPrice: Rs." + totalcost.ToString();

            orderDetails = msg;

            MessageBox.Show("Pizza Order Placed Successfully!", "Pizza Order", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmDetails details = new frmDetails();
            details.Show();

            
        }

        private void rdoSmall_CheckedChanged(object sender, EventArgs e)
        {
            size = rdoSmall.Text;
        }

        private void rdoMedium_CheckedChanged(object sender, EventArgs e)
        {
            size = rdoMedium.Text;
        }

        private void rdoLarge_CheckedChanged(object sender, EventArgs e)
        {
            size = rdoLarge.Text;
        }

        private void rdoThin_CheckedChanged(object sender, EventArgs e)
        {
            crust = rdoThin.Text;
        }

        private void rdoThick_CheckedChanged(object sender, EventArgs e)
        {
            crust = rdoThick.Text;
        }

        private void rdoEatIn_CheckedChanged(object sender, EventArgs e)
        {
            eat = rdoEatIn.Text;
        }

        private void rdoPark_CheckedChanged(object sender, EventArgs e)
        {
            eat = rdoPark.Text;
        }

        private void rdoTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            eat = rdoTakeOut.Text;
        }

        private void rdoDeliver_CheckedChanged(object sender, EventArgs e)
        {
            eat = rdoDeliver.Text;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstChoice.Items.Clear();
            category = cmbCategory.Text;
            if (cmbCategory.Text == "Classic")
            {
                lstChoice.Items.Add("Devilled Chicken");
                lstChoice.Items.Add("Cheese Lovers");
                lstChoice.Items.Add("Tandoori Chicken");
                lstChoice.Items.Add("Sausage Delight");
            }
            else if (cmbCategory.Text == "Signature")
            {
                lstChoice.Items.Add("Spicy Veggie");
                lstChoice.Items.Add("Black Chicken");
                lstChoice.Items.Add("BBQ Chicken");
                lstChoice.Items.Add("Chicken Hawaiian");
                lstChoice.Items.Add("Chicken Masala");
                lstChoice.Items.Add("Cheese Fiesta");
                lstChoice.Items.Add("Spicy Chicken");
            }
            else if (cmbCategory.Text == "Favourite")
            {
                lstChoice.Items.Add("Sri Lankan Spicy");
                lstChoice.Items.Add("Butter Cuttlefish");
                lstChoice.Items.Add("Prawn with Chicken");
                lstChoice.Items.Add("Veggie Supreme");
                lstChoice.Items.Add("Beef Pepperoni");
                lstChoice.Items.Add("Meat Lovers");
            }
            else if (cmbCategory.Text == "Supreme")
            {
                lstChoice.Items.Add("Chicken Treat");
                lstChoice.Items.Add("Garlic Prawns");
                lstChoice.Items.Add("Spicy Seafood");
            }

            
        }

        private void lstChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            choice = lstChoice.GetItemText(lstChoice.SelectedItem);
        }
    }
}
