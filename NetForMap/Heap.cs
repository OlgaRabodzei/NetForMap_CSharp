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
            this.points = _points;
            int pointsCount = _points.Length; 
            
            int leafsCount = pointsCount;
            leafsCount = leafsCount - 1;
            leafsCount = leafsCount | (leafsCount >> 1);
            leafsCount = leafsCount | (leafsCount >> 2);
            leafsCount = leafsCount | (leafsCount >> 4);
            leafsCount = leafsCount | (leafsCount >> 8);
            leafsCount = leafsCount | (leafsCount >> 16);
            leafsCount = leafsCount | (leafsCount >> 32);
            leafsCount = leafsCount + 1;

            this.count = 2 * leafsCount - 1;
            this.heap = new int[this.count];

            for (int i = 0; i < pointsCount; i++) {
                this.heap[this.count - 1 - i] = i;
            }
            for (int i = count - 1 - pointsCount; i >= 0; i--) {
                this.heap[i] = int.MinValue;
            }
            BuildHeap();
        }

        private void BuildHeap() {
            //int pointsStartInHeap = points.Length - 1;
            int pointsCount = this.points.Length;
            for (int i = 1; i < pointsCount - 1; i++) {
                SiftUp(this.count - 1 - i);
            }
        }

        private void SiftUp(int index) {
            if (index == 0) return;
           
            if (heap[(index - 1) / 2] == int.MinValue) {
                heap[(index - 1) / 2] = heap[index];
                SiftUp((index - 1) / 2);
            }
            if ((index & 1) == 0 && heap[index - 1] != int.MinValue) {
                if (points[heap[index - 1]].getConsumption() < points[heap[index]].getConsumption()) {
                    heap[(index - 1) / 2] = heap[index];
                }
                else {
                    heap[(index - 1) / 2] = heap[index - 1];
                }
                SiftUp((index - 1) / 2);
            }
            if ((index & 1) == 1 && heap[index + 1] != int.MinValue) {
                if (points[heap[index + 1]].getConsumption() < points[heap[index]].getConsumption()) {
                    heap[(index - 1) / 2] = heap[index];
                }
                else {
                    heap[(index - 1) / 2] = heap[index + 1];
                }
                SiftUp((index - 1) / 2);
            }
        }

        public Pair GetMax()
        {
            return points[heap[0]];
        }

        public int GetIndexOfMax() { return heap[0]; }

        public void ChangePriority(double newPriority, int index) {
            points[index].setConsumption(newPriority);
            //SiftUp(points.Length - 1 + index);
            SiftUp(heap.Length - 1 - index);
        }
    }
}
