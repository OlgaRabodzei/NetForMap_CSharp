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
