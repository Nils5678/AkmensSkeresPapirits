﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkmensSkeresPapirits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void butCredits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nils Deičmanis", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
