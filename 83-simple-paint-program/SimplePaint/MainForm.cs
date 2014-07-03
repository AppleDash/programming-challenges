using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class MainForm : Form
    {
        private bool drawing = false;
        private Bitmap redBitmap, blueBitmap, yellowBitmap, greenBitmap, orangeBitmap, pinkBitmap, purpleBitmap, brownBitmap, blackBitmap, whiteBitmap;
        private Color currentColor = Color.Black;
        public MainForm()
        {
            InitializeComponent();
            SetupPaint();
        }

        private void SetupPaint()
        {
            InitializePaintingBox();

            redBitmap = MakeBitmap(redBox, Color.Red);
            blueBitmap = MakeBitmap(blueBox, Color.DarkBlue);
            yellowBitmap = MakeBitmap(yellowBox, Color.Yellow);
            greenBitmap = MakeBitmap(greenBox, Color.Green);
            orangeBitmap = MakeBitmap(orangeBox, Color.Orange);
            pinkBitmap = MakeBitmap(pinkBox, Color.Pink);
            purpleBitmap = MakeBitmap(purpleBox, Color.Purple);
            brownBitmap = MakeBitmap(brownBox, Color.Brown);
            blackBitmap = MakeBitmap(blackBox, Color.Black);
            whiteBitmap = MakeBitmap(whiteBox, Color.White);
            UpdateCurrent(blackBitmap);
        }

        private void InitializePaintingBox()
        {
            paintingBox.Image = new Bitmap(paintingBox.Width, paintingBox.Height);
            for (int x = 0; x < paintingBox.Width; x++)
            {
                for (int y = 0; y < paintingBox.Height; y++)
                {
                    ((Bitmap)paintingBox.Image).SetPixel(x, y, Color.White);
                }
            }
        }

        private Bitmap MakeBitmap(PictureBox pb, Color c)
        {
            Bitmap b = new Bitmap(pb.Width, pb.Height);
            for (int x = 0; x < pb.Width; x++)
            {
                for (int y = 0; y < pb.Height; y++)
                {
                    b.SetPixel(x, y, c);
                }
            }
            b.Borderize();

            pb.Image = b;

            return b;
        }

        private void SetPixels(Bitmap b, int x, int y, Color c)
        {
            int[][] map = { // Our brush is 3px by 3px
                new int[] {x, y},
                new int[] {x-1, y},
                new int[] {x, y-1},
                new int[] {x+1, y},
                new int[] {x, y+1},
                new int[] {x+1, y+1},
                new int[] {x-1, y-1},
                new int[] {x-1, y+1},
                new int[] {x+1, y-1}
            };

            foreach (int[] pair in map)
            {
                if (pair[0] >= b.Width || pair[1] >= b.Height || pair[0] < 0 || pair[1] < 0) // Happens when painting at edges.
                {
                    continue;
                }
                b.SetPixel(pair[0], pair[1], c);
            }
        }

        private void UpdateCurrent(Bitmap b)
        {
            currentBox.Image = b;
            currentColor = b.GetPixel(1, 1);
        }

        /* Here be event handlers */

        private void paintingBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs ea = (MouseEventArgs)e;
            Bitmap b = (Bitmap)paintingBox.Image;
            Point mouseLoc = ea.Location;
            SetPixels(b, mouseLoc.X, mouseLoc.Y, currentColor);
            paintingBox.Image = b;
        }

        private void paintingBox_MouseMove(object sender, MouseEventArgs ea)
        {
            if (drawing)
            {
                Bitmap b = (Bitmap)paintingBox.Image;
                Point mouseLoc = ea.Location;
                SetPixels(b, mouseLoc.X, mouseLoc.Y, currentColor);
                paintingBox.Image = b;
            }
        }

        private void paintingBox_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
        }

        private void paintingBox_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            InitializePaintingBox();
        }

        /* Yes it is horrible, no I didn't feel like doing it another way. */

        private void redBox_Click(object sender, EventArgs e)
        {
            UpdateCurrent(redBitmap);
        }

        private void blueBox_Click(object sender, EventArgs e)
        {
            UpdateCurrent(blueBitmap);
        }

        private void yellowBox_Click(object sender, EventArgs e)
        {
            UpdateCurrent(yellowBitmap);
        }

        private void greenBox_Click(object sender, EventArgs e)
        {
            UpdateCurrent(greenBitmap);
        }

        private void orangeBox_Click(object sender, EventArgs e)
        {
            UpdateCurrent(orangeBitmap);
        }

        private void purpleBox_Click(object sender, EventArgs e)
        {
            UpdateCurrent(purpleBitmap);
        }

        private void pinkBox_Click(object sender, EventArgs e)
        {
            UpdateCurrent(pinkBitmap);
        }

        private void brownBox_Click(object sender, EventArgs e)
        {
            UpdateCurrent(brownBitmap);
        }

        private void blackBox_Click(object sender, EventArgs e)
        {
            UpdateCurrent(blackBitmap);
        }

        private void whiteBox_Click(object sender, EventArgs e)
        {
            UpdateCurrent(whiteBitmap);
        }
    }
}
