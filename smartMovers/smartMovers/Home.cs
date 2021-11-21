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
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void frm_Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Can't update record,invalid data type","invalid data",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Record Deleted!!", "Deleted",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
