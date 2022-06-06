﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HASS_Group_v1._0
{
    public partial class xmlForm : Form
    {
        public xmlForm()
        {
            InitializeComponent();
        }
        void MoveIndicator(Control control)
        {
            indicator.Top = control.Top;
            indicator.Height = control.Height;
        }

        private void bunifuTileButton15_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            xmlForm xml = new xmlForm();
            xml.Show();
            this.Hide();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            csvForm csv = new csvForm();
            csv.Show();
            this.Hide();
        }

        private void xmlForm_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            jsonForm json = new jsonForm();
            json.Show();
            this.Hide();
        }

        private void richTextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
