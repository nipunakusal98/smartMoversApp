﻿using System;
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
    public partial class frm_Vehicle : Form
    {
        public frm_Vehicle()
        {
            InitializeComponent();
        }

        private void Vehicle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartMoversDataSet6.Vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.Fill(this.smartMoversDataSet6.Vehicle);

        }
    }
}
