﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace SimpleApp1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;
            MessageBox.Show("Вы ввели: " + userInput, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void MainForm_DoubleClick(object sender, EventArgs e)
        {
            clickLabel.Visible = true;
            var newvar = new NewClass();
            newvar.Name = "";
        }
            
    }
}
