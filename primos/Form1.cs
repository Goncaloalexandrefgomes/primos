﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primos
{
    public partial class Form1 : Form
    {
        primos fait = new primos();

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            fait.recebe = textBox1.Text;
            label1.Text = fait.envia;
        }
    }
}