﻿//Periodic Table in Sinhala
//SaanSoft 2019 All Rights Reserved.
//Author :- Sahan S Liyanage
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Periodic_Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1 .CheckedChanged += new EventHandler(backColor_ColorChanged);
            radioButton2 .CheckedChanged += new EventHandler(backColor_ColorChanged);
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Color dark = Color.FromArgb(64, 64, 64);
        Color light = Color.FromArgb(245, 245, 245);
        Color white = Color.FromKnownColor(KnownColor.White);
        Color black = Color.FromKnownColor(KnownColor.Black);
        private void backColor_ColorChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.BackColor = light;
                label1.ForeColor = black;
                radioButton1.ForeColor = black;
                radioButton2.ForeColor = black ;
            }
            else if (radioButton2.Checked)
            {
                this.BackColor = dark;
                label1.ForeColor = white;
                radioButton1.ForeColor = white;
                radioButton2.ForeColor = white;
            }
        }
    }
}
