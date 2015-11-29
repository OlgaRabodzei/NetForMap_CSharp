namespace NetForMap
{
    //Binary max-heap
    class Heap
    {
        private int count = 0;
        private int lastIndex = 0;
        private Pair[] heap;

        public Heap(int _count, Pair first)
        {
            this.count = _count;
            this.heap = new Pair[_count];
            this.heap[0] = first;
        }

        private void SiftUp(int index)
        {
            if (index == 0) return;
            if (heap[(index - 1) / 2] < heap[index])
            {
                Pair a = heap[index];
                heap[index] = heap[(index - 1) / 2];
                heap[(index - 1) / 2] = a;

                SiftUp((index - 1) / 2);
            }
        }

        private void SiftDown(int index)
        {
            if (index == this.count) return;
            //if there is one child
            int minChildIndex = 0;
            if (2 * index + 1 < this.count)
                minChildIndex = 2 * index + 1;
            else
                return;
            //if there are two children choose max
            if (
                ((2 * index + 2) < this.count) &&
                (heap[2 * index + 1] < heap[2 * index + 2])
              )
                minChildIndex = 2 * index + 2;
            //compare parent and child
            if (heap[index] < heap[minChildIndex])
            {
                Pair a = heap[index];
                heap[index] = heap[minChildIndex];
                heap[minChildIndex] = a;

                SiftDown(minChildIndex);
            }
        }

        public void Insert(Pair p)
        {
            if (this.lastIndex + 1 == this.count) return;
            this.lastIndex++;
            this.heap[lastIndex] = p;
            SiftUp(lastIndex);
        }

        public Pair GetMax()
        {
            return this.heap[0];
        }

        public void ChangePriority(double newPriority, int index = 0)
        {
            this.heap[index].setConsumption(newPriority);
            if (index == 0)
            {
                SiftDown(0);
            }
            else if (index < this.count && this.heap[index / 2] < this.heap[index]) //if parent is smaller
            { SiftUp(index); }
            else { SiftDown(index); }
        }

        public int FindPathWithPoint(ref int heapIndex, int point, bool itFinish = true)
        {
            if (itFinish)
            {
                for (int i = 0; i < this.count; i++)
                {
                    if (this.heap[i].getFinish() == point)
                    {
                        heapIndex = i;
                        return this.heap[i].getStart();
                    }
                }
            }
            else //it's start
            {
                for (int i = 0; i < this.count; i++)
                {
                    if (this.heap[i].getStart() == point)
                    {
                        heapIndex = i;
                        return this.heap[i].getFinish();
                    }
                }
            }
            return -1;
        }
    }
}
