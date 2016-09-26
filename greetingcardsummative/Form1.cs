using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

// Created by Carter Bott
// on September 19th, 2016
// to complete the greeting card summative

namespace greetingcardsummative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {
            DrawInside();
        }

        private void dateLabel_Click(object sender, EventArgs e)
        {
            DrawInside();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            DrawInside();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {
            DrawInside();
        }

        public void DrawInside()
        {
            Graphics fg = this.CreateGraphics();
            dateLabel.Visible = false;
            titleLabel.Visible = false;
            nameLabel.Visible = false;
            fg.Clear(Color.FromArgb(255,0,0,255));

            Thread.Sleep(250);
        
            for (int i = 0; i < 255; i++)

            Thread.Sleep(250);

            {
                Thread.Sleep(5);
                fg.Clear(Color.FromArgb(255, 0, 0, 255-i));
            }
            









        }

    }
}
