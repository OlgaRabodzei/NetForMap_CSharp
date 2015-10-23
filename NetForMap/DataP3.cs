namespace NetForMap
{
    public struct DataP3
    {
        private double x;
        private double y;
        private double z;

        public DataP3(double _x, double _y, double _z)
        { this.x = _x; this.y = _y; this.z = _z; }

        public double X
        { get { return x; } set { x = value; } }

        public double Y
        { get { return y; } set { y = value; } }

        public double Z
        { get { return z; } set { z = value; } }
    }
}
