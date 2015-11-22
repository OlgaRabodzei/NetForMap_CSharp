using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
namespace NetForMap
{
    static class Draw
    {
        static DataP3 CrossPoint(DataP3 p1, DataP3 p2, float H)
        {
            double deltaH = (H - p1.H) / (p2.H - p1.H);
            double x = 0.0f;
            double y = 0.0f;

            if ((p1.X < p2.X) || (p1.X > p2.X))
            {
                x = Math.Min(p1.X, p2.X) + deltaH;
                y = p1.Y;
            }

            if ((p1.Y < p2.Y) || (p1.Y > p2.Y))
            {
                x = p1.X;
                y = Math.Min(p1.Y, p2.Y) + deltaH;
            }

            //if (p1.X > p2.X)
            //{ x = p2.X + deltaH; y = p2.y; }

            //if (p1.Y > p2.Y)
            //{ x = p2.X; y = p2.y + deltaH; }


            return new DataP3(x,y,H);
        }

        static DataP3 CheckExpression(DataP3 p1, DataP3 p2, float H)
        {
            if (
                ((p1.H - H) < 0 && (H - p2.H) < 0) ||
                ((p1.H - H) > 0 && (H - p2.H) > 0)
              )
            { return CrossPoint(p1, p2, H); }
            else return new DataP3(0,0,-1);
        }

        public static void DrawAllIsolines(DataP3[,] Points, ref PaintEventArgs e) 
        {
            DrawIsoline(Points, 0.5f, ref e);
        }

        static void DrawIsoline(DataP3[,] Points, float H, ref PaintEventArgs e)
        {
            List<PointF> crossPoints = new List<PointF>();
            int rows = Points.GetLength(0);
            int cols = Points.GetLength(1);

            for (int i = 0; i < rows-1; i++)
            {
                for (int j = 0; j < cols-1; j++)
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
                        DrawCrossLines(crossPoints, ref e);
                    crossPoints.Clear();
                }
            }
           
        }

        static void DrawCrossLines(List<PointF> crossPoints, ref PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 0.0f);
            e.Graphics.DrawLine(pen, crossPoints[0], crossPoints[1]);
            if (crossPoints.Count == 3)
            {
                e.Graphics.DrawLine(pen, crossPoints[0], crossPoints[2]);
                e.Graphics.DrawLine(pen, crossPoints[1], crossPoints[2]);
            }
            //e.Graphics.DrawClosedCurve(pen, crossPoints.ToArray());
        }
    }
}