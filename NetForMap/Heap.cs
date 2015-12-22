namespace NetForMap
{
    //Binary max-heap
    class Heap
    {
        private int count = 0;
        private int lastIndex = 0;
        private int[] heap;
        private Pair[] points;

        public Heap(Pair[] _points)
        {
            int pointsCount = _points.Length;
            this.count = 2*(pointsCount-1);
            this.heap = new int[this.count];
            for (int i = pointsCount - 2; i > 0; i--) {
                this.heap[i] = int.MinValue;
            }
            for (int i = this.count - 1; i >= pointsCount-1; i--) {
                this.heap[i] = this.count - i;
            }
            BuildHeap();
        }

        private void BuildHeap() {
            int pointsStartInHeap = points.Length - 1;
            for (int i = count - 1; i >= pointsStartInHeap; i--) {
                SiftUp(i);
            }
        }

        private void SiftUp(int index)
        {
            if (index == 0) return;
            if (heap[(index - 1) / 2] == int.MinValue || // If parent is empty OR
                points[heap[(index - 1) / 2]].getConsumption() < points[heap[index]].getConsumption()) // If cur priority is greater
            {
                heap[(index - 1) / 2] = heap[index];
                SiftUp((index - 1) / 2);
            }
        }

        public Pair GetMax()
        {
            return points[heap[0]];
        }

        public void ChangePriority(double newPriority, int index) {
            points[index].setConsumption(newPriority);
            SiftUp(points.Length - 1 + index);
        }
    }
}
