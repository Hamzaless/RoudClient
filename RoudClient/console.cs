﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoudClient
{
    public partial class console : Form
    {
        public console()
        {
            InitializeComponent();
        }

        private void console_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
