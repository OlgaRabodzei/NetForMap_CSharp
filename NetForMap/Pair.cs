namespace NetForMap
{
    class Pair
    {
        private int start;
        private int finish;
        private double consumption;

        /*public Pair()
        {
            this.point = new DataP3();
            this.consumption = double.MinValue;
        }*/

        public Pair(int _start, int _finish, double _consumption)
        {
            this.start = _start;
            this.finish = _finish;
            this.consumption = _consumption;
        }

        public int getStart()
        {
            return this.start;
        }

        public int getFinish()
        {
            return this.finish;
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