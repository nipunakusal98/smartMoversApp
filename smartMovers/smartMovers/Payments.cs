using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frm_Payments : Form
    {
        public frm_Payments()
        {
            InitializeComponent();
        }

        private void frm_Payments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartMoversDataSet5.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter1.Fill(this.smartMoversDataSet5.Payment);
            // TODO: This line of code loads data into the 'smartMoversDataSet4.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.smartMoversDataSet4.Payment);

        }
    }
}
