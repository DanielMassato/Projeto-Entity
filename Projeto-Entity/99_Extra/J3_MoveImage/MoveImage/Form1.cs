using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoveImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        int oldX = 0, oldY = 0;
        
 
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            oldX = e.X;
            oldY = e.Y;

            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
        
        }

        int x = 0, y = 0;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
                x += e.X - oldX;
                y += e.Y - oldY;
               
                
                //pictureBox1.Image. Margin = new Padding(x, y, 0, 0);
                //Graphics g = pictureBox1.CreateGraphics();
                //g.Clear(Color.White);
                //g.DrawImage(pictureBox1.Image, new Point(x, y));               
                pictureBox1.Invalidate();
                //g.DrawImage(Properties.Resources.P25_06_10_11_11, new Point(x, y));               

                oldX = e.X;
                oldY = e.Y;
            }
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Bitmap bmp = new Bitmap();
            e.Graphics.DrawImage(Properties.Resources.P25_06_10_11_11, new Point(x, y));               
        }
    }
}
