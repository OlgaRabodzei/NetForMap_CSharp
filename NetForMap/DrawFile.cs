using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
namespace NetForMap
{
    public class Draw
    {
        private static Draw instance;
        private Graphics graphics;

        private Draw(PictureBox pictureBox) {
            this.graphics = pictureBox.CreateGraphics();
        }

        public static Draw getInstance(PictureBox pictureBox)
        {
            if (instance == null) instance = new Draw(pictureBox);
            return instance;
        }

        static DataP3 CrossPoint(DataP3 p1, DataP3 p2, float H)
        {
            //double deltaH = (H - p1.H) / (p2.H - p1.H);
            double x = 0.0f;
            double y = 0.0f;

            /*
            if ((p1.X < p2.X) || (p1.X > p2.X))
            {
                y = p1.Y;
                //x = (Math.Abs(H - p1.H) < Math.Abs(H - p2.H)) ? p1.X : p2.X;
                x = p1.X;
                x += deltaH;
            }

            if ((p1.Y < p2.Y) || (p1.Y > p2.Y))
            {
                x = p1.X;
                //y = (Math.Abs(H - p1.H) < Math.Abs(H - p2.H)) ? p1.Y : p2.Y;
                y = p1.Y;
                y += deltaH;
            }
            */

            if ((p1.X < p2.X) || (p1.X > p2.X))
            {
                if (Math.Abs(H - p1.H) < Math.Abs(H - p2.H))
                {
                    double deltaH = (H - p1.H) / (p2.H - p1.H);
                    x = p1.X;
                    if (p1.X < p2.X)
                        x += deltaH;
                    else
                        x -= deltaH;
                }
                else
                {
                    double deltaH = (H - p2.H) / (p1.H - p2.H);
                    x = p2.X;
                    if (p1.X > p2.X)
                        x += deltaH;
                    else
                        x -= deltaH;
                }
                y = p1.Y;
            }

            if ((p1.Y < p2.Y) || (p1.Y > p2.Y))
            {
                if (Math.Abs(H - p1.H) < Math.Abs(H - p2.H))
                {
                    double deltaH = (H - p1.H) / (p2.H - p1.H);
                    y = p1.Y;
                    if (p1.Y < p2.Y)
                        y += deltaH;
                    else
                        y -= deltaH;
                }
                else
                {
                    double deltaH = (H - p2.H) / (p1.H - p2.H);
                    y = p2.Y;
                    if (p1.Y > p2.Y)
                        y += deltaH;
                    else
                        y -= deltaH;
                }
                x = p1.X;
            }

            return new DataP3(x, y, H);
        }

        static DataP3 CheckExpression(DataP3 p1, DataP3 p2, float H)
        {
            if (
                ((p1.H - H) < 0 && (H - p2.H) < 0) ||
                ((p1.H - H) > 0 && (H - p2.H) > 0)
              )
            { return CrossPoint(p1, p2, H); }
            else return new DataP3(0, 0, -1);
        }

        public void DrawAllIsolines(DataP3[,] Points)
        {
            //ДОДЕЛАТЬ! автоматическое построение всех
            DrawIsoline(Points, 0.0f);
            DrawIsoline(Points, 0.5f);
            DrawIsoline(Points, 1.0f);
            DrawIsoline(Points, 1.5f);
            DrawIsoline(Points, 2.0f);
            DrawIsoline(Points, 2.5f);
            DrawIsoline(Points, 3.0f);
            DrawIsoline(Points, 3.5f);
        }

        private void DrawIsoline(DataP3[,] Points, float H)
        {
            List<PointF> crossPoints = new List<PointF>();
            int rows = Points.GetLength(0);
            int cols = Points.GetLength(1);

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    DataP3 crPoint;
                    //up
                    crPoint = CheckExpression(Points[i, j], Points[i, j + 1], H);
                    if (crPoint.H != -1)
                        crossPoints.Add((PointF)crPoint);
                    //right
                    crPoint = CheckExpression(Points[i, j + 1], Points[i + 1, j + 1], H);
                    if (crPoint.H != -1)
                        crossPoints.Add((PointF)crPoint);
                    //down
                    crPoint = CheckExpression(Points[i + 1, j + 1], Points[i + 1, j], H);
                    if (crPoint.H != -1)
                        crossPoints.Add((PointF)crPoint);
                    //left
                    crPoint = CheckExpression(Points[i + 1, j], Points[i, j], H);
                    if (crPoint.H != -1)
                        crossPoints.Add((PointF)crPoint);

                    if (crossPoints.Count > 1 && crossPoints.Count < 4)
                        DrawCrossLines(crossPoints);
                    crossPoints.Clear();
                }
            }

        }

        private void DrawCrossLines(List<PointF> crossPoints)
        {
            Pen pen = new Pen(Color.Red, 0.0f);
            graphics.DrawLine(pen, crossPoints[0], crossPoints[1]);
            if (crossPoints.Count == 3)
            {
                graphics.DrawLine(pen, crossPoints[0], crossPoints[2]);
                graphics.DrawLine(pen, crossPoints[1], crossPoints[2]);
            }
            //e.Graphics.DrawClosedCurve(pen, crossPoints.ToArray());
        }

        public void DrawPath(DataP3[] path)
        {
            Pen pen = new Pen(Color.BlueViolet, 0.05f);
            Pen pen1 = new Pen(Color.Green, 0.0f);
            graphics.DrawLines(pen, DataP3.ToPointFArray(path));
            //e.Graphics.DrawCurve(pen, DataP3.ToPointFArray(path));
        }
    }
}