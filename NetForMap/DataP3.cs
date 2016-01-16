namespace NetForMap
{
    public struct DataP3
    {
        private double x;
        private double y;
        private double h;

        public DataP3(double _x, double _y, double _h)
        { this.x = _x; this.y = _y; this.h = _h; }

        public double X
        { get { return x; } set { x = value; } }

        public double Y
        { get { return y; } set { y = value; } }

        public double H
        { get { return h; } set { h = value; } }

        public static explicit operator System.Drawing.PointF(DataP3 p)
        {
            return new System.Drawing.PointF((float)p.X, (float)p.Y);
        }

        public static System.Drawing.PointF[] ToPointFArray(DataP3[] data)
        {
            int n = data.Length;
            System.Drawing.PointF[] newData = new System.Drawing.PointF[n];
            for (int i = 0; i < n; i++)
            {
                newData[i] = new System.Drawing.PointF((float)data[i].X, (float)data[i].Y);
            }
            return newData;
        }

        public static void FindMinMaxCoordinates(DataP3[] dataPoints, ref double minX, ref double maxX, ref double minY, ref double maxY) {
            minX = maxX = dataPoints[0].X;
            minY = maxY = dataPoints[0].Y;
            for (int i = 1; i < dataPoints.Length; ++i) {
                if (dataPoints[i].X < minX) minX = dataPoints[i].X;
                if (dataPoints[i].X > maxX) maxX = dataPoints[i].X;
                if (dataPoints[i].Y < minY) minY = dataPoints[i].Y;
                if (dataPoints[i].Y > maxY) maxY = dataPoints[i].Y;
            }
        }

        public static void FindMinMaxHeight(DataP3[,] dataPoints, ref double minH, ref double maxH) {
            minH = maxH = dataPoints[0, 0].H;
            for (int i = 1; i < dataPoints.GetLength(0); ++i)
                for (int j = 0; j < dataPoints.GetLength(1); j++) {
                    if (dataPoints[i, j].H < minH) minH = dataPoints[i, j].H;
                    if (dataPoints[i, j].H > maxH) maxH = dataPoints[i, j].H;
                }
        }

       /* public static bool operator ==(DataP3 d1, DataP3 d2)
        {
            if (d1.X == d2.X && d1.Y == d2.Y && d1.H == d2.H)
                return true;
            return false;
        }

        public static bool operator !=(DataP3 d1, DataP3 d2)
        {
            if (d1.X != d2.X || d1.Y != d2.Y || d1.H != d2.H)
                return true;
            return false;
        }*/
    }
}
