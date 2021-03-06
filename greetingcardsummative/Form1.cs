﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Media;

// Created by Carter Bott
// on September 19th, 2016
// to complete the greeting card summative.

namespace greetingcardsummative
{
    public partial class ariesCard : Form
    {
        public ariesCard()
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DrawInside();
        }

        public void DrawInside()
        {
            Graphics fg = this.CreateGraphics(); //This block creates the form graphics and removes all items from the screen when the button is pressed                                                
            dateLabel.Visible = false;
            titleLabel.Visible = false;
            ariesPicture.Visible = false;
            nameLabel.Visible = false;
            fg.Clear(Color.FromArgb(255,0,0,255));

            Thread.Sleep(250);

            for (int i = 0; i < 255; i++) //Creates the fading effect from blue to black
            {
                Thread.Sleep(5);
                fg.Clear(Color.FromArgb(255, 0, 0, 255 - i)); 
            }

            Thread.Sleep(500); //Tells the program to delay before drawing the stars 

            SolidBrush starBrush = new SolidBrush(Color.White); //Brush for drawing the stars
            Pen linePen = new Pen(Color.White, 1);
            fg.FillEllipse(starBrush, 54, 68, 10, 10);

            Font drawFont = new Font("DejaVu Serif", 8, FontStyle.Bold); //Block for creating and storing all the required fonts
            Font resetFont = new Font("Arial", 10, FontStyle.Underline);
            SolidBrush resetBrush = new SolidBrush(Color.Green);
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            SolidBrush titleBrush = new SolidBrush(Color.Red);

            SoundPlayer star = new SoundPlayer(Properties.Resources.star);      //Block that creates all required sound players
            SoundPlayer typing = new SoundPlayer(Properties.Resources.typing);

            Thread.Sleep(500);

            fg.FillEllipse(starBrush, 120, 95, 10, 10);
            star.Play();

            Thread.Sleep(500);

            fg.FillEllipse(starBrush, 170, 118, 10, 10);
       
            Thread.Sleep(500);

            fg.FillEllipse(starBrush, 195, 155, 10, 10);
                
            Thread.Sleep(500);

            fg.DrawLine(linePen, 55, 71, 120, 97);

            Thread.Sleep(500);

            fg.DrawLine(linePen, 120, 97, 169, 121);

            Thread.Sleep(500);

            fg.DrawLine(linePen, 172, 121, 195, 156);

            Thread.Sleep(2000);

            fg.DrawString("Aries Constellation", titleFont, titleBrush, 150, 20);
            typing.Play();

            Thread.Sleep(2000);

            fg.DrawString("Aries is one of the constellations of the zodiac.", drawFont, drawBrush, 5, 235);
            typing.Play();

            Thread.Sleep(2000);

            fg.DrawString("It is located in the northern celestial hemisphere ", drawFont, drawBrush, 5, 250);
            typing.Play();

            Thread.Sleep(2000);

            fg.DrawString("between Pisces to the west and Taurus to the east.", drawFont, drawBrush, 5, 265);
            typing.Play();

            Thread.Sleep(2000);

            fg.DrawString("The name Aries is Latin for ram, it's shape is said to ", drawFont, drawBrush, 5, 280);
            typing.Play();

            Thread.Sleep(2000);

            fg.DrawString("resemble a rams horns.", drawFont, drawBrush, 5, 295);
            typing.Play();

            Thread.Sleep(2000);

            fg.DrawString("Click anywhere to resart the program.", resetFont, resetBrush, 40, 340);

        }
    }
}
