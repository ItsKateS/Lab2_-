using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.Util;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Image<Bgr, byte> sourceImg;
        PointF[] pts = new PointF[4];
        int index = 0;

        private void LoadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            var result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = ofd.FileName;
                sourceImg = new Image<Bgr, byte>(fileName);
            }

            OG.Image = sourceImg.Resize(OG.Width, OG.Height, Inter.Linear);
        }

        private void Scale_Click(object sender, EventArgs e)
        {
            double k = double.Parse(ScaleNum.Text);
            var scaledImg = new Image<Bgr, byte>((int)(sourceImg.Width * k), 
                (int)(sourceImg.Height * k));

            for(int x = 0; x < scaledImg.Width - 1; x++)
                for(int y = 0; y < scaledImg.Height - 1; y++)
                {
                    double X = x / k;
                    double Y = y / k;

                    double floorX = Math.Floor(X);
                    double floorY = Math.Floor(Y);

                    if (floorX >= sourceImg.Width - 1) continue;
                    if (floorY >= sourceImg.Height - 1) continue;

                    double ratioX = X - floorX;
                    double ratioY = Y - floorY;

                    double invRatioX = 1 - ratioX;
                    double invRatioY = 1 - ratioY;

                    Bgr c1 = new Bgr();

                    c1.Blue = (sourceImg.Data[(int)floorX, (int)floorY, 0]
                        * invRatioX + sourceImg.Data[(int)floorX, (int)(floorY + 1), 0] * ratioX);

                    c1.Green = (sourceImg.Data[(int)floorX, (int)floorY, 1]
                        * invRatioX + sourceImg.Data[(int)floorX, (int)(floorY + 1), 1] * ratioX);

                    c1.Red = (sourceImg.Data[(int)floorX, (int)floorY, 2]
                        * invRatioX + sourceImg.Data[(int)floorX, (int)(floorY + 1), 2] * ratioX);

                    Bgr c2 = new Bgr();

                    c2.Blue = (sourceImg.Data[(int)(floorX + 1), (int)floorY, 0]
                        * invRatioX + sourceImg.Data[(int)(floorX + 1), (int)(floorY + 1), 0] * ratioX);

                    c2.Green = (sourceImg.Data[(int)(floorX + 1), (int)floorY, 1]
                        * invRatioX + sourceImg.Data[(int)(floorX + 1), (int)(floorY + 1), 1] * ratioX);

                    c2.Red = (sourceImg.Data[(int)(floorX + 1), (int)floorY, 2]
                        * invRatioX + sourceImg.Data[(int)(floorX + 1), (int)(floorY + 1), 2] * ratioX);

                    
                    Bgr c = new Bgr();

                    c.Blue = c1.Blue * invRatioY + c2.Blue * ratioY;
                    c.Green = c1.Green * invRatioY + c2.Green * ratioY;
                    c.Red = c1.Red * invRatioY + c2.Red * ratioY;

                    scaledImg[x, y] = c;

                }

            Res.Image = scaledImg;
        }

        private void OG_MouseClick(object sender, MouseEventArgs e)
        {
            var imgCopy = sourceImg.Copy();

            int x = (int)(e.Location.X / OG.ZoomScale);
            int y = (int)(e.Location.Y / OG.ZoomScale);

            pts[index] = new Point(x, y);
            index++;

            if (index >= pts.Length)
                index = 0;

            int radius = 2;
            int thickness = 2;
            var color = new Bgr(Color.Red).MCvScalar;

            for (int i = 0; i < 4; i++)
            CvInvoke.Circle(imgCopy, new Point((int)pts[i].X, (int)pts[i].Y), radius, color, thickness);

            OG.Image = imgCopy;
        }

        private void Project_Click(object sender, EventArgs e)
        {
            var destPoints = new PointF[]
            {
                new PointF(0, 0),
                new PointF(0, sourceImg.Height - 1),
                new PointF(sourceImg.Width - 1, sourceImg.Height - 1),
                new PointF(sourceImg.Width - 1, 0)
            };

            var homographyMatrix = CvInvoke.GetPerspectiveTransform(pts, destPoints);

            var destImage = new Image<Bgr, byte>(sourceImg.Size);
            CvInvoke.WarpPerspective(sourceImg, destImage, homographyMatrix, destImage.Size);

            Res.Image = destImage;
        }

        private void Shear_Click(object sender, EventArgs e)
        {
            double k = double.Parse(ShearNum.Text);
            var shearImg = new Image<Bgr, byte>((int)(sourceImg.Width + k),
                sourceImg.Height);

            for (int x = 0; x < sourceImg.Width; x++)
                for (int y = 0; y < sourceImg.Height; y++)
                {
                    int newX = (int)(x + k * (sourceImg.Height - y));
                    int newY = y;

                    if (newX >= 0 && newX < shearImg.Width && newY >= 0 && newY < shearImg.Height)
                        shearImg[newY, newX] = sourceImg[y, x];
                }

            Res.Image = shearImg;
        }

        private void Rotation_Click(object sender, EventArgs e)
        {
            int centerX = int.Parse(CenterX.Text);
            int centerY = int.Parse(CenterY.Text);
            int angle = int.Parse(Angle.Text);
            double rad = convRad(angle);

            double cosRad = Math.Cos(rad);
            double sinRad = Math.Sin(rad);

            var rotatedImg = new Image<Bgr, byte>((int)(Math.Abs(cosRad * sourceImg.Width) + Math.Abs(sinRad * sourceImg.Height)),
                (int)(Math.Abs(sinRad * sourceImg.Width) + Math.Abs(cosRad * sourceImg.Height)));

            for (int x = 0; x < sourceImg.Width; x++)
                for (int y = 0; y < sourceImg.Height; y++)
                {
                    int newX = (int)(cosRad * (x - centerX) - sinRad * (y - centerY) + centerX);
                    int newY = (int)(sinRad * (x - centerX) + cosRad * (y - centerY) + centerY);

                    if (newX < 0 || newX >= rotatedImg.Width || newY < 0 || newY >= rotatedImg.Height) continue;

                    double floorX = Math.Floor((double)newX);
                    double floorY = Math.Floor((double)newY);

                    if (floorX >= sourceImg.Width - 1) continue;
                    if (floorY >= sourceImg.Height - 1) continue;

                    double ratioX = newX - floorX;
                    double ratioY = newY - floorY;

                    double invRatioX = 1 - ratioX;
                    double invRatioY = 1 - ratioY;

                    Bgr c1 = new Bgr();

                    c1.Blue = (sourceImg.Data[(int)floorX, (int)floorY, 0]
                        * invRatioX + sourceImg.Data[(int)floorX, (int)(floorY + 1), 0] * ratioX);

                    c1.Green = (sourceImg.Data[(int)floorX, (int)floorY, 1]
                        * invRatioX + sourceImg.Data[(int)floorX, (int)(floorY + 1), 1] * ratioX);

                    c1.Red = (sourceImg.Data[(int)floorX, (int)floorY, 2]
                        * invRatioX + sourceImg.Data[(int)floorX, (int)(floorY + 1), 2] * ratioX);

                    Bgr c2 = new Bgr();

                    c2.Blue = (sourceImg.Data[(int)(floorX + 1), (int)floorY, 0]
                        * invRatioX + sourceImg.Data[(int)(floorX + 1), (int)(floorY + 1), 0] * ratioX);

                    c2.Green = (sourceImg.Data[(int)(floorX + 1), (int)floorY, 1]
                        * invRatioX + sourceImg.Data[(int)(floorX + 1), (int)(floorY + 1), 1] * ratioX);

                    c2.Red = (sourceImg.Data[(int)(floorX + 1), (int)floorY, 2]
                        * invRatioX + sourceImg.Data[(int)(floorX + 1), (int)(floorY + 1), 2] * ratioX);


                    Bgr c = new Bgr();

                    c.Blue = c1.Blue * invRatioY + c2.Blue * ratioY;
                    c.Green = c1.Green * invRatioY + c2.Green * ratioY;
                    c.Red = c1.Red * invRatioY + c2.Red * ratioY;

                    rotatedImg[x, y] = c;
                }

            Res.Image = rotatedImg;
        }

        static double convRad(int deg)
        {
            return deg * Math.PI / 180;
        }

        private void Reflection_Click(object sender, EventArgs e)
        {
            int flipX = int.Parse(FlipX.Text);
            int flipY = int.Parse(FlipY.Text);

            var reflectImg = new Image<Bgr, byte>(sourceImg.Width * Math.Abs(flipX), sourceImg.Height * Math.Abs(flipY));

            for (int x = 0; x < sourceImg.Width; x++)
            {
                for (int y = 0; y < sourceImg.Height; y++)
                {
                    int newX = flipX == 1 ? x : (reflectImg.Width - 1 - x);
                    int newY = flipY == 1 ? y : (reflectImg.Height - 1 - y);

                    reflectImg[newY, newX] = sourceImg[y, x];
                }
            }

            Res.Image = reflectImg.Resize(Res.Width, Res.Height, Inter.Linear);
        }
    }
}
