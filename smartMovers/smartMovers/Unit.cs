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
    public partial class frm_Unit : Form
    {
        public frm_Unit()
        {
            InitializeComponent();
        }

        private void frm_Unit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartMoversDataSet8.Unit' table. You can move, or remove it, as needed.
            this.unitTableAdapter.Fill(this.smartMoversDataSet8.Unit);

        }
    }
}
