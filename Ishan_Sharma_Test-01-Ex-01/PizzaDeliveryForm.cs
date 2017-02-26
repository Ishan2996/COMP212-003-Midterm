using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ishan_Sharma_Test_01_Ex_01
{
    public partial class PizzaDeliveryForm : Form
    {
        double subTotal = 0;
        const double TOPPING_PRICE = 1.50;
        public PizzaDeliveryForm()
        {
            InitializeComponent();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                string type = "";
                string customerName = customerUserControl2.CustomerName;
                string address = customerUserControl2.DeliverAddress;
                if (rbtnSmall.Checked)
                {
                    type = rbtnSmall.Text;
                    subTotal += 10.0;
                }
                else if (rbtnMedium.Checked)
                {
                    type = rbtnMedium.Text;
                    subTotal += 12.0;
                }
                else if (rbtnLarge.Checked)
                {
                    type = rbtnLarge.Text;
                    subTotal += 14.0;
                }
                txtSubTotal.Text = subTotal.ToString("c");
                txtOrderSummary.Text = customerName + "\t" + address + "\t" + type;
                txtTotalHst.Text = (subTotal + (0.13 * subTotal)).ToString("c");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Thanks for Choosing " + cmbPizzaShop.SelectedItem.ToString() + "!. We will deliver your pizza in next 45 minutes. ");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClearOrderSummary_Click(object sender, EventArgs e)
        {
            txtOrderSummary.Clear();
            txtTotalHst.Clear();
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            try
            {
                txtSubTotal.Clear();
                customerUserControl2.CustomerName = null;
                customerUserControl2.OrderNumber = null;
                customerUserControl2.DeliverAddress = null;
                customerUserControl2.Contact = null;
                chkCapsicum.Checked = false;
                chkMushroom.Checked = false;
                chkOlives.Checked = false;
                chkOnions.Checked = false;
                chkPepperoni.Checked = false;
                chkTomatoes.Checked = false;
                rbtnLarge.Checked = false;
                rbtnMedium.Checked = false;
                rbtnSmall.Checked = false;
                cmbPizzaShop.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOlives.Checked)
            {
                txtSubTotal.Text = (subTotal += TOPPING_PRICE).ToString();
            }
            else
            {
                txtSubTotal.Text = (subTotal -= TOPPING_PRICE).ToString();
            }
        }

        private void chkCapsicum_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCapsicum.Checked)
            {
                txtSubTotal.Text = (subTotal += TOPPING_PRICE).ToString();
            }
            else
            {
                txtSubTotal.Text = (subTotal -= TOPPING_PRICE).ToString();
            }
        }

        private void chkOnions_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnions.Checked)
            {
                txtSubTotal.Text = (subTotal += TOPPING_PRICE).ToString();
            }
            else
            {
                txtSubTotal.Text = (subTotal -= TOPPING_PRICE).ToString();
            }
        }

        private void chkMushroom_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMushroom.Checked)
            {
                txtSubTotal.Text = (subTotal += TOPPING_PRICE).ToString();
            }
            else
            {
                txtSubTotal.Text = (subTotal -= TOPPING_PRICE).ToString();
            }
        }

        private void chkPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPepperoni.Checked)
            {
                txtSubTotal.Text = (subTotal += TOPPING_PRICE).ToString();
            }
            else
            {
                txtSubTotal.Text = (subTotal -= TOPPING_PRICE).ToString();
            }
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTomatoes.Checked)
            {
                txtSubTotal.Text = (subTotal += TOPPING_PRICE).ToString();
            }
            else
            {
                txtSubTotal.Text = (subTotal -= TOPPING_PRICE).ToString();
            }
        }

        private void txtTotalHst_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
