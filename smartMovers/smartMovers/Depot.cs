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
    public partial class frm_Depot : Form
    {
        public frm_Depot()
        {
            InitializeComponent();
        }

        private void frm_Depot_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartMoversDataSet3.Depot' table. You can move, or remove it, as needed.
            this.depotTableAdapter.Fill(this.smartMoversDataSet3.Depot);

        }
    }
}
