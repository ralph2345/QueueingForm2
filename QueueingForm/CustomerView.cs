using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueingForm
{
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            lblToDisplay.Text = LabelMethod;
        }

        public string LabelMethod
        {
            get { return this.lblToDisplay.Text; }

            set { lblToDisplay.Text = value; }
        }
    }
}
