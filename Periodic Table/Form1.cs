//Periodic Table in Sinhala
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
            radioButton3.CheckedChanged += new EventHandler(language_languageChanged);
            radioButton4.CheckedChanged += new EventHandler(language_languageChanged);

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
                label2.ForeColor = black;
                label3.ForeColor = black;
                label4.ForeColor = black;
                radioButton1.ForeColor = black;
                radioButton2.ForeColor = black;
                radioButton3.ForeColor = black;
                radioButton4.ForeColor = black;
            }
            else if (radioButton2.Checked)
            {
                this.BackColor = dark;
                label1.ForeColor = white;
                label2.ForeColor = white;
                label3.ForeColor = white;
                label4.ForeColor = white;
                radioButton1.ForeColor = white;
                radioButton2.ForeColor = white;
                radioButton3.ForeColor = white;
                radioButton4.ForeColor = white;
            }
        }
        private void language_languageChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                label1.Text = "Theme";
                label2.Text = "Periodic Table";
                label3.Text = "Language";
                radioButton1.Text = "Light";
                radioButton2.Text = "Dark";
                radioButton3.Text = "English";
                radioButton4.Text = "Sinhala";
            }
            else if (radioButton4.Checked)
            {
                label1.Text = "තේමාව";
                label2.Text = "ආවර්තිතා වගුව";
                label3.Text = "භාෂාව";
                radioButton1.Text = "ආලෝකවත්";
                radioButton2.Text = " අඳුරු";
                radioButton3.Text = "ඉංග්‍රීසි";
                radioButton4.Text = "සිංහල";
            }
        }
    }
}
