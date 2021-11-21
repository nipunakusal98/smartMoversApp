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
    public partial class frm_Product : Form
    {
        public frm_Product()
        {
            InitializeComponent();
        }

        private void frm_Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartMoversDataSet1.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.smartMoversDataSet1.Product);

        }
    }
}
