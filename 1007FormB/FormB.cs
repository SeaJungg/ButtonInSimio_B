﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1007FormB
{
    public partial class FormB : Form
    {
        public FormB()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            textBox.Text = "Hi";
        }
    }
}