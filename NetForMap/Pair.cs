namespace NetForMap
{
    class Pair
    {
        private DataP3 point;
        private double consumption;

        public Pair()
        {
            this.point = new DataP3();
            this.consumption = double.MinValue;
        }

        public Pair(DataP3 _point, double _consumption = double.MinValue)
        {
            this.point = _point;
            this.consumption = _consumption;
        }

        public DataP3 getPoint()
        {
            return this.point;
        }

        public double getConsumption()
        {
            return this.consumption;
        }

        public void setConsumption(double _consumption)
        {
           this.consumption = _consumption;
        }

        public static bool operator <(Pair p1, Pair p2)
        {
            if (p1.getConsumption() < p2.getConsumption())
                return true;
            return false;
        }

        public static bool operator >(Pair p1, Pair p2)
        {
            if (p1.getConsumption() > p2.getConsumption())
                return true;
            return false;
        }
    }
}