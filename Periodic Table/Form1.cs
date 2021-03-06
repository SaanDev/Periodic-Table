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
                lbl1.ForeColor = black;
                lbl2.ForeColor = black;
                lbl3.ForeColor = black;
                lbl4.ForeColor = black;
                lbl5.ForeColor = black;
                lbl6.ForeColor = black;
                lbl7.ForeColor = black;
                lbl8.ForeColor = black;
                lbl9.ForeColor = black;
                lbl10.ForeColor = black;
                lbl11.ForeColor = black;
                lbl12.ForeColor = black;
                lbl13.ForeColor = black;
                lbl14.ForeColor = black;
                lbl15.ForeColor = black;
                lbl16.ForeColor = black;
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
                lbl1.ForeColor = white;
                lbl2.ForeColor = white;
                lbl3.ForeColor = white;
                lbl4.ForeColor = white;
                lbl5.ForeColor = white;
                lbl6.ForeColor = white;
                lbl7.ForeColor = white;
                lbl8.ForeColor = white;
                lbl9.ForeColor = white;
                lbl10.ForeColor = white;
                lbl11.ForeColor = white;
                lbl12.ForeColor = white;
                lbl13.ForeColor = white;
                lbl14.ForeColor = white;
                lbl15.ForeColor = white;
                lbl16.ForeColor = white;
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
                lbl1.Text = "Name:";
                lbl2.Text = "Atomic Number:";
                lbl3.Text = "Group:";
                lbl4.Text = "Period:";
                lbl5.Text = "Electron Configuration:";
                lbl6.Text = "Phase:";
                lbl7.Text = "Melting Point:";
                lbl8.Text = "Boiling Point:";
                lbl9.Text = "Density:";
                lbl10.Text = "Triple Point:";
                lbl11.Text = "Oxidation State(s):";
                lbl12.Text = "Electronegativity:";
                lbl13.Text = "Speed of Sound:";
                lbl14.Text = "Descovery:";
                lbl15.Text = "Named By:";
                lbl16.Text = "Atomic Mass";
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
                lbl1.Text = "මූලද්‍රව්‍යය:";
                lbl2.Text = "පරමාණුක ක්‍රමාංකය:";
                lbl3.Text = "කාණ්ඩය:";
                lbl4.Text = "ආවර්තය:";
                lbl5.Text = "ඉලෙක්ට්‍රෝන වින්‍යාසය:";
                lbl6.Text = "භෞතික අවස්ථාව:";
                lbl7.Text = "ද්‍රවාංකය:";
                lbl8.Text = "තාපාංකය:";
                lbl9.Text = "ඝනත්වය:";
                lbl10.Text = "ත්‍රික ලක්ෂ්‍යය:";
                lbl11.Text = "ඔක්සිකරණ අවස්ථා(ව):";
                lbl12.Text = "විද්‍යුත් ඍණතාවය:";
                lbl13.Text = "ශබ්දයේ වේගය:";
                lbl14.Text = "සොයාගැනීම:";
                lbl15.Text = "නම් කිරීම:";
                lbl16.Text = "පරමාණුක ස්කන්ධය";
            }
        }
        System.Data.SqlClient.SqlConnection con;
        DataSet ds1;
        System.Data.SqlClient.SqlDataAdapter da;
        private void btnH_Click(object sender, EventArgs e)
        {
            con = new System.Data.SqlClient.SqlConnection();
            ds1 = new DataSet();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\elements.mdf;Integrated Security=True";
            con.Open();
            string sql = "SELECT * From elements";
            da = new System.Data.SqlClient.SqlDataAdapter(sql, con);
            da.Fill(ds1, "elements");
            NavigateRecordsH();
            //MessageBox.Show("Database Connected");
            con.Close();
            //MessageBox.Show("Database disconnected");
            con.Dispose();
        }
        private void NavigateRecordsH()
        {
            DataRow dRow = ds1.Tables["elements"].Rows[0];
            txtname.Text = dRow.ItemArray.GetValue(0).ToString();
            txtatmnum.Text = dRow.ItemArray.GetValue(1).ToString();
            txtgroup.Text = dRow.ItemArray.GetValue(2).ToString();
            txtperiod.Text = dRow.ItemArray.GetValue(3).ToString();
            txtelecconfig.Text = dRow.ItemArray.GetValue(4).ToString();
            txtphase.Text = dRow.ItemArray.GetValue(5).ToString();
            txtmelting.Text = dRow.ItemArray.GetValue(6).ToString();
            txtboiling.Text = dRow.ItemArray.GetValue(7).ToString();
            txtdensity.Text = dRow.ItemArray.GetValue(8).ToString();
            txttriple.Text = dRow.ItemArray.GetValue(9).ToString();
            txtoxidation.Text = dRow.ItemArray.GetValue(10).ToString();
            txtelecneg.Text = dRow.ItemArray.GetValue(11).ToString();
            txtspdoflight.Text = dRow.ItemArray.GetValue(12).ToString();
            txtdescovery.Text = dRow.ItemArray.GetValue(13).ToString();
            txtnamedby.Text = dRow.ItemArray.GetValue(14).ToString();
            txtatmmass.Text = dRow.ItemArray.GetValue(15).ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHe_Click(object sender, EventArgs e)
        {
            con = new System.Data.SqlClient.SqlConnection();
            ds1 = new DataSet();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\elements.mdf;Integrated Security=True";
            con.Open();
            string sql = "SELECT * From elements";
            da = new System.Data.SqlClient.SqlDataAdapter(sql, con);
            da.Fill(ds1, "elements");
            NavigateRecordsHe();
            //MessageBox.Show("Database Connected");
            con.Close();
            //MessageBox.Show("Database disconnected");
            //con.Dispose();
        }
        private void NavigateRecordsHe()
        {
            DataRow dRow = ds1.Tables["elements"].Rows[1];
            txtname.Text = dRow.ItemArray.GetValue(0).ToString();
            txtatmnum.Text = dRow.ItemArray.GetValue(1).ToString();
            txtgroup.Text = dRow.ItemArray.GetValue(2).ToString();
            txtperiod.Text = dRow.ItemArray.GetValue(3).ToString();
            txtelecconfig.Text = dRow.ItemArray.GetValue(4).ToString();
            txtphase.Text = dRow.ItemArray.GetValue(5).ToString();
            txtmelting.Text = dRow.ItemArray.GetValue(6).ToString();
            txtboiling.Text = dRow.ItemArray.GetValue(7).ToString();
            txtdensity.Text = dRow.ItemArray.GetValue(8).ToString();
            txttriple.Text = dRow.ItemArray.GetValue(9).ToString();
            txtoxidation.Text = dRow.ItemArray.GetValue(10).ToString();
            txtelecneg.Text = dRow.ItemArray.GetValue(11).ToString();
            txtspdoflight.Text = dRow.ItemArray.GetValue(12).ToString();
            txtdescovery.Text = dRow.ItemArray.GetValue(13).ToString();
            txtnamedby.Text = dRow.ItemArray.GetValue(14).ToString();
            txtatmmass.Text = dRow.ItemArray.GetValue(15).ToString();
        }

        private void btnLi_Click(object sender, EventArgs e)
        {
            con = new System.Data.SqlClient.SqlConnection();
            ds1 = new DataSet();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\elements.mdf;Integrated Security=True";
            con.Open();
            string sql = "SELECT * From elements";
            da = new System.Data.SqlClient.SqlDataAdapter(sql, con);
            da.Fill(ds1, "elements");
            NavigateRecordsLi();
            //MessageBox.Show("Database Connected");
            con.Close();
            //MessageBox.Show("Database disconnected");
            //con.Dispose();
        }
        private void NavigateRecordsLi()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtatmmass.Clear();
            txtatmnum.Clear();
            txtboiling.Clear();
            txtdensity.Clear();
            txtdescovery.Clear();
            txtelecconfig.Clear();
            txtelecneg.Clear();
            txtgroup.Clear();
            txtmelting.Clear();
            txtname.Clear();
            txtnamedby.Clear();
            txtoxidation.Clear();
            txtperiod.Clear();
            txtphase.Clear();
            txtspdoflight.Clear();
            txttriple.Clear();
           
        }
        int MaxRows = 0;
        int inc = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            con = new System.Data.SqlClient.SqlConnection();
            ds1 = new DataSet();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\elements.mdf;Integrated Security=True";
            con.Open();
            string sql = "SELECT * From elements";
            da = new System.Data.SqlClient.SqlDataAdapter(sql, con);
            da.Fill(ds1, "elements");
            NavigateRecordsLi();
            //MessageBox.Show("Database Connected");
            con.Close();
            //MessageBox.Show("Database disconnected");
            //con.Dispose();
            System.Data.SqlClient.SqlCommandBuilder cb;
            cb = new System.Data.SqlClient.SqlCommandBuilder(da);
            DataRow dRow = ds1.Tables["elements"].NewRow();
            dRow[0] = txtatmnum.Text;
            dRow[1] = txtname.Text;
            dRow[2] = txtgroup.Text;
            dRow[3] = txtperiod.Text;
            dRow[4] = txtelecconfig.Text;
            dRow[5] = txtphase.Text;
            dRow[6] = txtmelting.Text;
            dRow[7] = txtboiling.Text;
            dRow[8] = txtdensity.Text;
            dRow[9] = txttriple.Text;
            dRow[10] = txtoxidation.Text;
            dRow[11] = txtelecneg.Text;
            dRow[12] = txtspdoflight.Text;
            dRow[13] = txtdescovery.Text;
            dRow[14] = txtnamedby.Text;
            dRow[15] = txtatmmass.Text;
            ds1.Tables["elements"].Rows.Add(dRow);
            MaxRows = MaxRows + 1;
            inc = MaxRows - 1;
            da.Update(ds1, "elements");
            MessageBox.Show("Element Added");
        }

        private void label21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
