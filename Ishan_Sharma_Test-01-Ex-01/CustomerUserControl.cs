using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ishan_Sharma_Test_01_Ex_01
{
    public partial class CustomerUserControl : UserControl
    {
        public CustomerUserControl()
        {
            InitializeComponent();
        }

        public string  OrderNumber
        {
            get { return txtOrderNumber.Text; }
            set { txtOrderNumber.Text = value; }
        }

        public string CustomerName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string DeliverAddress
        {
            get { return txtDeliveryAddress.Text; }
            set { txtDeliveryAddress.Text = value; }
        }

        public string Contact
        {
            get { return txtContact.Text; }
            set { txtContact.Text = value; }
        }
    }
}
