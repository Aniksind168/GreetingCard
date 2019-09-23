using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

/// <summary>
/// Created By Anika Sindwani 
/// September 2019
/// Christmas Greeting Card
/// </summary>
namespace GreetingCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Presets
            Graphics g = this.CreateGraphics();

            //Pen
            Pen titlePen = new Pen(Color.Red, width: 2);

            //First Font
            Font titleFont = new Font("MurrayHill Bd BT", 50, FontStyle.Bold);

            //Colour Palette
            SolidBrush titleBrush = new SolidBrush(Color.Red);
            SolidBrush titleBrush3 = new SolidBrush(Color.DarkGreen);
            SolidBrush titleBrush4 = new SolidBrush(Color.LimeGreen);
            SolidBrush titleBrush5 = new SolidBrush(Color.Yellow);
            SolidBrush titleBrush6 = new SolidBrush(Color.Blue);
            SolidBrush titleBrush7 = new SolidBrush(Color.DarkRed);

            //Card Sound
            SoundPlayer opening1 = new SoundPlayer(Properties.Resources.opening_1);
            opening1.Play();

            //Card Colour
            g.Clear(Color.LimeGreen);

            //Merry Christmas
            g.DrawString("Merry", titleFont, titleBrush, 105, 25);
            g.DrawString("Christmas", titleFont, titleBrush, 80, 375);

            //Wreath
            g.FillEllipse(titleBrush3, 90, 145, 200, 200);
            g.FillEllipse(titleBrush4, 148, 203, 85, 85);

            //Ornaments on Wreath
            g.FillEllipse(titleBrush, 115, 190, 20, 20);
            g.FillEllipse(titleBrush5, 105, 240, 20, 20);
            g.FillEllipse(titleBrush6, 125, 292, 20, 20);
            g.FillEllipse(titleBrush, 245, 190, 20, 20);
            g.FillEllipse(titleBrush5, 255, 240, 20, 20);
            g.FillEllipse(titleBrush6, 235, 290, 20, 20);
            g.FillEllipse(titleBrush7, 180, 168, 20, 20);

            //Bow 
            g.DrawEllipse(titlePen, 155, 280, 40, 20);
            g.DrawEllipse(titlePen, 185, 280, 40, 20);
            g.DrawLine(titlePen, 190, 295, 220, 320);
            g.DrawLine(titlePen, 190, 295, 165, 320);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //Presets
            Graphics g = this.CreateGraphics();

            //Pen
            Pen titlePen = new Pen(Color.DarkGreen, width: 2);

            //Font 2
            Font titleFont2 = new Font("Gabriola", 36, FontStyle.Bold);

            //Colour Palette
            SolidBrush titleBrush = new SolidBrush(Color.Red);
            SolidBrush titleBrush3 = new SolidBrush(Color.DarkGreen);
            SolidBrush titleBrush4 = new SolidBrush(Color.LimeGreen);
            SolidBrush titleBrush5 = new SolidBrush(Color.Yellow);
            SolidBrush titleBrush6 = new SolidBrush(Color.Blue);
            SolidBrush titleBrush7 = new SolidBrush(Color.DarkRed);
            SolidBrush titleBrush8 = new SolidBrush(Color.White);
            SolidBrush titleBrush9 = new SolidBrush(Color.SaddleBrown);

            // Card Opening
            SoundPlayer opening2 = new SoundPlayer(Properties.Resources.Opening);
            opening2.Play();

            //Card Colour
            g.Clear(Color.Crimson);
            
            //Have a Happy Holidays!
            g.DrawString("Have a Happy Holiday!", titleFont2, titleBrush8, 10, 25);

            //Christmas Tree
            g.FillPie(titleBrush3, 100, 2, 200, 200, 60, 60);
            g.FillPie(titleBrush3, 75, 2, 250, 280, 60, 60);
            g.FillRectangle(titleBrush9, 175, 350, 50, 100);
            g.FillPie(titleBrush3, 75, 2, 250, 370, 60, 60);

            //Ornaments on Christmas Tree Version 1
            g.DrawString("Have a Happy Holiday!", titleFont2, titleBrush3, 10, 25);

            g.FillEllipse(titleBrush, 190, 130, 20, 20);

            g.FillEllipse(titleBrush5, 170, 170, 20, 20);
            g.FillEllipse(titleBrush6, 210, 170, 20, 20);

            g.FillEllipse(titleBrush6, 155, 230, 20, 20);
            g.FillEllipse(titleBrush, 190, 230, 20, 20);
            g.FillEllipse(titleBrush5, 225, 230, 20, 20);

            g.FillEllipse(titleBrush5, 135, 300, 20, 20);
            g.FillEllipse(titleBrush, 170, 300, 20, 20);
            g.FillEllipse(titleBrush6, 205, 300, 20, 20);
            g.FillEllipse(titleBrush, 240, 300, 20, 20);

            Thread.Sleep(250);

            //Ornaments on Christmas Tree Version 2
            g.DrawString("Have a Happy Holiday!", titleFont2, titleBrush8, 10, 25);

            g.FillEllipse(titleBrush6, 190, 130, 20, 20);

            g.FillEllipse(titleBrush, 170, 170, 20, 20);
            g.FillEllipse(titleBrush5, 210, 170, 20, 20);

            g.FillEllipse(titleBrush, 155, 230, 20, 20);
            g.FillEllipse(titleBrush5, 190, 230, 20, 20);
            g.FillEllipse(titleBrush6, 225, 230, 20, 20);

            g.FillEllipse(titleBrush, 135, 300, 20, 20);
            g.FillEllipse(titleBrush5, 170, 300, 20, 20);
            g.FillEllipse(titleBrush, 205, 300, 20, 20);
            g.FillEllipse(titleBrush6, 240, 300, 20, 20);

            Thread.Sleep(250);

            //Ornaments on Christmas Tree Version 3
            g.DrawString("Have a Happy Holiday!", titleFont2, titleBrush3, 10, 25);

            g.FillEllipse(titleBrush6, 190, 130, 20, 20);

            g.FillEllipse(titleBrush5, 170, 170, 20, 20);
            g.FillEllipse(titleBrush, 210, 170, 20, 20);

            g.FillEllipse(titleBrush6, 155, 230, 20, 20);
            g.FillEllipse(titleBrush5, 190, 230, 20, 20);
            g.FillEllipse(titleBrush, 225, 230, 20, 20);

            g.FillEllipse(titleBrush, 135, 300, 20, 20);
            g.FillEllipse(titleBrush6, 170, 300, 20, 20);
            g.FillEllipse(titleBrush5, 205, 300, 20, 20);
            g.FillEllipse(titleBrush, 240, 300, 20, 20);

            Thread.Sleep(250);

            //Ornaments on Christmas Tree Version 1 (Repeat)
            g.DrawString("Have a Happy Holiday!", titleFont2, titleBrush8, 10, 25);

            g.FillEllipse(titleBrush, 190, 130, 20, 20);

            g.FillEllipse(titleBrush5, 170, 170, 20, 20);
            g.FillEllipse(titleBrush6, 210, 170, 20, 20);

            g.FillEllipse(titleBrush6, 155, 230, 20, 20);
            g.FillEllipse(titleBrush, 190, 230, 20, 20);
            g.FillEllipse(titleBrush5, 225, 230, 20, 20);

            g.FillEllipse(titleBrush5, 135, 300, 20, 20);
            g.FillEllipse(titleBrush, 170, 300, 20, 20);
            g.FillEllipse(titleBrush6, 205, 300, 20, 20);
            g.FillEllipse(titleBrush, 240, 300, 20, 20);

            Thread.Sleep(250);

            //Ornaments on Christmas Tree Version 2 (Repeat)
            g.DrawString("Have a Happy Holiday!", titleFont2, titleBrush3, 10, 25);

            g.FillEllipse(titleBrush6, 190, 130, 20, 20);

            g.FillEllipse(titleBrush, 170, 170, 20, 20);
            g.FillEllipse(titleBrush5, 210, 170, 20, 20);

            g.FillEllipse(titleBrush, 155, 230, 20, 20);
            g.FillEllipse(titleBrush5, 190, 230, 20, 20);
            g.FillEllipse(titleBrush6, 225, 230, 20, 20);

            g.FillEllipse(titleBrush, 135, 300, 20, 20);
            g.FillEllipse(titleBrush5, 170, 300, 20, 20);
            g.FillEllipse(titleBrush, 205, 300, 20, 20);
            g.FillEllipse(titleBrush6, 240, 300, 20, 20);

            Thread.Sleep(250);

            //Ornaments on Christmas Tree Version 3 (Repeat)
            g.DrawString("Have a Happy Holiday!", titleFont2, titleBrush8, 10, 25);

            g.FillEllipse(titleBrush6, 190, 130, 20, 20);

            g.FillEllipse(titleBrush5, 170, 170, 20, 20);
            g.FillEllipse(titleBrush, 210, 170, 20, 20);

            g.FillEllipse(titleBrush6, 155, 230, 20, 20);
            g.FillEllipse(titleBrush5, 190, 230, 20, 20);
            g.FillEllipse(titleBrush, 225, 230, 20, 20);

            g.FillEllipse(titleBrush, 135, 300, 20, 20);
            g.FillEllipse(titleBrush6, 170, 300, 20, 20);
            g.FillEllipse(titleBrush5, 205, 300, 20, 20);
            g.FillEllipse(titleBrush, 240, 300, 20, 20);

            Thread.Sleep(250);

            //Ornaments on Christmas Tree Version 1 (Repeat)
            g.DrawString("Have a Happy Holiday!", titleFont2, titleBrush3, 10, 25);

            g.FillEllipse(titleBrush, 190, 130, 20, 20);

            g.FillEllipse(titleBrush5, 170, 170, 20, 20);
            g.FillEllipse(titleBrush6, 210, 170, 20, 20);

            g.FillEllipse(titleBrush6, 155, 230, 20, 20);
            g.FillEllipse(titleBrush, 190, 230, 20, 20);
            g.FillEllipse(titleBrush5, 225, 230, 20, 20);

            g.FillEllipse(titleBrush5, 135, 300, 20, 20);
            g.FillEllipse(titleBrush, 170, 300, 20, 20);
            g.FillEllipse(titleBrush6, 205, 300, 20, 20);
            g.FillEllipse(titleBrush, 240, 300, 20, 20);

            Thread.Sleep(250);

            //Ornaments on Christmas Tree Version 2 (Repeat)
            g.DrawString("Have a Happy Holiday!", titleFont2, titleBrush8, 10, 25);

            g.FillEllipse(titleBrush6, 190, 130, 20, 20);

            g.FillEllipse(titleBrush, 170, 170, 20, 20);
            g.FillEllipse(titleBrush5, 210, 170, 20, 20);

            g.FillEllipse(titleBrush, 155, 230, 20, 20);
            g.FillEllipse(titleBrush5, 190, 230, 20, 20);
            g.FillEllipse(titleBrush6, 225, 230, 20, 20);

            g.FillEllipse(titleBrush, 135, 300, 20, 20);
            g.FillEllipse(titleBrush5, 170, 300, 20, 20);
            g.FillEllipse(titleBrush, 205, 300, 20, 20);
            g.FillEllipse(titleBrush6, 240, 300, 20, 20);

            Thread.Sleep(250);

            //Ornaments on Christmas Tree Version 3 (Repeat)
            g.DrawString("Have a Happy Holiday!", titleFont2, titleBrush3, 10, 25);

            g.FillEllipse(titleBrush6, 190, 130, 20, 20);

            g.FillEllipse(titleBrush5, 170, 170, 20, 20);
            g.FillEllipse(titleBrush, 210, 170, 20, 20);

            g.FillEllipse(titleBrush6, 155, 230, 20, 20);
            g.FillEllipse(titleBrush5, 190, 230, 20, 20);
            g.FillEllipse(titleBrush, 225, 230, 20, 20);

            g.FillEllipse(titleBrush, 135, 300, 20, 20);
            g.FillEllipse(titleBrush6, 170, 300, 20, 20);
            g.FillEllipse(titleBrush5, 205, 300, 20, 20);
            g.FillEllipse(titleBrush, 240, 300, 20, 20);

            Thread.Sleep(250);

            //Ornaments on Christmas Tree Version 1 (Repeat)
            g.DrawString("Have a Happy Holiday!", titleFont2, titleBrush8, 10, 25);

            g.FillEllipse(titleBrush, 190, 130, 20, 20);

            g.FillEllipse(titleBrush5, 170, 170, 20, 20);
            g.FillEllipse(titleBrush6, 210, 170, 20, 20);

            g.FillEllipse(titleBrush6, 155, 230, 20, 20);
            g.FillEllipse(titleBrush, 190, 230, 20, 20);
            g.FillEllipse(titleBrush5, 225, 230, 20, 20);

            g.FillEllipse(titleBrush5, 135, 300, 20, 20);
            g.FillEllipse(titleBrush, 170, 300, 20, 20);
            g.FillEllipse(titleBrush6, 205, 300, 20, 20);
            g.FillEllipse(titleBrush, 240, 300, 20, 20);

            Thread.Sleep(250);

            //Ornaments on Christmas Tree Version 2 (Repeat)
            g.DrawString("Have a Happy Holiday!", titleFont2, titleBrush3, 10, 25);

            g.FillEllipse(titleBrush6, 190, 130, 20, 20);

            g.FillEllipse(titleBrush, 170, 170, 20, 20);
            g.FillEllipse(titleBrush5, 210, 170, 20, 20);

            g.FillEllipse(titleBrush, 155, 230, 20, 20);
            g.FillEllipse(titleBrush5, 190, 230, 20, 20);
            g.FillEllipse(titleBrush6, 225, 230, 20, 20);

            g.FillEllipse(titleBrush, 135, 300, 20, 20);
            g.FillEllipse(titleBrush5, 170, 300, 20, 20);
            g.FillEllipse(titleBrush, 205, 300, 20, 20);
            g.FillEllipse(titleBrush6, 240, 300, 20, 20);

            Thread.Sleep(250);

            //Ornaments on Christmas Tree Version 3 (Repeat)
            g.DrawString("Have a Happy Holiday!", titleFont2, titleBrush8, 10, 25);

            g.FillEllipse(titleBrush6, 190, 130, 20, 20);

            g.FillEllipse(titleBrush5, 170, 170, 20, 20);
            g.FillEllipse(titleBrush, 210, 170, 20, 20);

            g.FillEllipse(titleBrush6, 155, 230, 20, 20);
            g.FillEllipse(titleBrush5, 190, 230, 20, 20);
            g.FillEllipse(titleBrush, 225, 230, 20, 20);

            g.FillEllipse(titleBrush, 135, 300, 20, 20);
            g.FillEllipse(titleBrush6, 170, 300, 20, 20);
            g.FillEllipse(titleBrush5, 205, 300, 20, 20);
            g.FillEllipse(titleBrush, 240, 300, 20, 20);

            Thread.Sleep(250);

            //Ornaments on Christmas Tree Version 1 (Repeat)
            g.DrawString("Have a Happy Holiday!", titleFont2, titleBrush3, 10, 25);

            g.FillEllipse(titleBrush, 190, 130, 20, 20);

            g.FillEllipse(titleBrush5, 170, 170, 20, 20);
            g.FillEllipse(titleBrush6, 210, 170, 20, 20);

            g.FillEllipse(titleBrush6, 155, 230, 20, 20);
            g.FillEllipse(titleBrush, 190, 230, 20, 20);
            g.FillEllipse(titleBrush5, 225, 230, 20, 20);

            g.FillEllipse(titleBrush5, 135, 300, 20, 20);
            g.FillEllipse(titleBrush, 170, 300, 20, 20);
            g.FillEllipse(titleBrush6, 205, 300, 20, 20);
            g.FillEllipse(titleBrush, 240, 300, 20, 20);

            Thread.Sleep(250);

            //Ornaments on Christmas Tree Version 2 (Repeat)
            g.DrawString("Have a Happy Holiday!", titleFont2, titleBrush8, 10, 25);

            g.FillEllipse(titleBrush6, 190, 130, 20, 20);

            g.FillEllipse(titleBrush, 170, 170, 20, 20);
            g.FillEllipse(titleBrush5, 210, 170, 20, 20);

            g.FillEllipse(titleBrush, 155, 230, 20, 20);
            g.FillEllipse(titleBrush5, 190, 230, 20, 20);
            g.FillEllipse(titleBrush6, 225, 230, 20, 20);

            g.FillEllipse(titleBrush, 135, 300, 20, 20);
            g.FillEllipse(titleBrush5, 170, 300, 20, 20);
            g.FillEllipse(titleBrush, 205, 300, 20, 20);
            g.FillEllipse(titleBrush6, 240, 300, 20, 20);

            Thread.Sleep(250);

            //Ornaments on Christmas Tree Version 3 (Repeat)
            g.DrawString("Have a Happy Holiday!", titleFont2, titleBrush3, 10, 25);

            g.FillEllipse(titleBrush6, 190, 130, 20, 20);

            g.FillEllipse(titleBrush5, 170, 170, 20, 20);
            g.FillEllipse(titleBrush, 210, 170, 20, 20);

            g.FillEllipse(titleBrush6, 155, 230, 20, 20);
            g.FillEllipse(titleBrush5, 190, 230, 20, 20);
            g.FillEllipse(titleBrush, 225, 230, 20, 20);

            g.FillEllipse(titleBrush, 135, 300, 20, 20);
            g.FillEllipse(titleBrush6, 170, 300, 20, 20);
            g.FillEllipse(titleBrush5, 205, 300, 20, 20);
            g.FillEllipse(titleBrush, 240, 300, 20, 20);

            Thread.Sleep(250);

            //Ornaments on Christmas Tree Version 1 (Repeat)
            g.DrawString("Have a Happy Holiday!", titleFont2, titleBrush8, 10, 25);

            g.FillEllipse(titleBrush, 190, 130, 20, 20);

            g.FillEllipse(titleBrush5, 170, 170, 20, 20);
            g.FillEllipse(titleBrush6, 210, 170, 20, 20);

            g.FillEllipse(titleBrush6, 155, 230, 20, 20);
            g.FillEllipse(titleBrush, 190, 230, 20, 20);
            g.FillEllipse(titleBrush5, 225, 230, 20, 20);

            g.FillEllipse(titleBrush5, 135, 300, 20, 20);
            g.FillEllipse(titleBrush, 170, 300, 20, 20);
            g.FillEllipse(titleBrush6, 205, 300, 20, 20);

            Thread.Sleep(250);

            //Ornaments on Christmas Tree Version 2 (Repeat)
            g.DrawString("Have a Happy Holiday!", titleFont2, titleBrush3, 10, 25);

            g.FillEllipse(titleBrush6, 190, 130, 20, 20);

            g.FillEllipse(titleBrush, 170, 170, 20, 20);
            g.FillEllipse(titleBrush5, 210, 170, 20, 20);

            g.FillEllipse(titleBrush, 155, 230, 20, 20);
            g.FillEllipse(titleBrush5, 190, 230, 20, 20);
            g.FillEllipse(titleBrush6, 225, 230, 20, 20);

            g.FillEllipse(titleBrush, 135, 300, 20, 20);
            g.FillEllipse(titleBrush5, 170, 300, 20, 20);
            g.FillEllipse(titleBrush, 205, 300, 20, 20);
            g.FillEllipse(titleBrush6, 240, 300, 20, 20);

            //Ornaments on Christmas Tree Version 3 (Repeat)
            g.DrawString("Have a Happy Holiday!", titleFont2, titleBrush8, 10, 25);

            g.FillEllipse(titleBrush6, 190, 130, 20, 20);

            g.FillEllipse(titleBrush5, 170, 170, 20, 20);
            g.FillEllipse(titleBrush, 210, 170, 20, 20);

            g.FillEllipse(titleBrush6, 155, 230, 20, 20);
            g.FillEllipse(titleBrush5, 190, 230, 20, 20);
            g.FillEllipse(titleBrush, 225, 230, 20, 20);

            g.FillEllipse(titleBrush, 135, 300, 20, 20);
            g.FillEllipse(titleBrush6, 170, 300, 20, 20);
            g.FillEllipse(titleBrush5, 205, 300, 20, 20);
            g.FillEllipse(titleBrush, 240, 300, 20, 20);

            Thread.Sleep(250);

            //Ornaments on Christmas Tree Version 1 (Repeat)
            g.DrawString("Have a Happy Holiday!", titleFont2, titleBrush3, 10, 25);

            g.FillEllipse(titleBrush, 190, 130, 20, 20);

            g.FillEllipse(titleBrush5, 170, 170, 20, 20);
            g.FillEllipse(titleBrush6, 210, 170, 20, 20);

            g.FillEllipse(titleBrush6, 155, 230, 20, 20);
            g.FillEllipse(titleBrush, 190, 230, 20, 20);
            g.FillEllipse(titleBrush5, 225, 230, 20, 20);

            g.FillEllipse(titleBrush5, 135, 300, 20, 20);
            g.FillEllipse(titleBrush, 170, 300, 20, 20);
            g.FillEllipse(titleBrush6, 205, 300, 20, 20);

            Thread.Sleep(250);

            //Ornaments on Christmas Tree Version 2 (Repeat)
            g.DrawString("Have a Happy Holiday!", titleFont2, titleBrush8, 10, 25);

            g.FillEllipse(titleBrush6, 190, 130, 20, 20);

            g.FillEllipse(titleBrush, 170, 170, 20, 20);
            g.FillEllipse(titleBrush5, 210, 170, 20, 20);

            g.FillEllipse(titleBrush, 155, 230, 20, 20);
            g.FillEllipse(titleBrush5, 190, 230, 20, 20);
            g.FillEllipse(titleBrush6, 225, 230, 20, 20);

            g.FillEllipse(titleBrush, 135, 300, 20, 20);
            g.FillEllipse(titleBrush5, 170, 300, 20, 20);
            g.FillEllipse(titleBrush, 205, 300, 20, 20);
            g.FillEllipse(titleBrush6, 240, 300, 20, 20);

            Thread.Sleep(250);

            //Card Colour
            g.Clear(Color.DarkGreen);

            //Last Message
            g.DrawString("From: Anika Sindwani :)", titleFont2, titleBrush, 10, 210);

        }
    }
}
