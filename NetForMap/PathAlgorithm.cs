//INPUT: two points A and B

using System;
namespace NetForMap
{
    public class PathAlgorithm
    {
        //как их познакомить?!
        Algorithm algorithm;

        //константы! вводятся в программу конфигом или с формы
        int n = 100; //кол-во разбиений
        double consumptionMin = 2;
        double coefOfConsumptionPos = 10;
        double coefOfConsumptionNeg = 5;
        int paramLocal = 20;//!!! дубликат из mainForm
        double hVariation = 0.25;

        //fields
        DataP3[] path;
        Heap heap;//затраты на отрезках пути
        DataP3 start;
        DataP3 finish;

        public PathAlgorithm(DataP3 _start, DataP3 _finish, ref Algorithm _algorithm)
        {
            this.start = _start;
            this.finish = _finish;
            this.algorithm = _algorithm;
            //ADD: read constants

            //точки пути
            path = new DataP3[n];

            FirstApproximation();
        }

        private void FirstApproximation()
        {
            Pair[] points = new Pair[n]; 
            #region Разбиение прямой на отрезки
            //параметры прямой
            double A = this.start.Y - finish.Y;
            double B = finish.X - this.start.X;
            double C = this.start.X * finish.Y - finish.X * this.start.Y;
            //размер отрезка разбиения
            double step = Math.Sqrt(Math.Pow((finish.X - this.start.X), 2) + Math.Pow((finish.Y - this.start.Y), 2)) / this.n;
            //записываем начало и конец
            //start.H = algorithm.ObjectiveFunc(start.X, start.Y, paramLocal);
            path[0] = this.start;
            //finish.H = algorithm.ObjectiveFunc(finish.X, finish.Y, paramLocal);
            path[n - 1] = this.finish;
            //задаем начальное значение Х для расчета точек на прямой
            double x = this.start.X;
            double y = this.start.Y;
            //цикл разбиения прямой на отрезки
            for (int i = 1; i < this.n-1; i++)
            {
                x = this.start.X + i * step;
                y = (-A * x - C) / B;
                double H = algorithm.ObjectiveFunc(x, y, paramLocal);
                path[i] = new DataP3(x, y, H); // do i need it?
            }
            #endregion
            #region Расчет затрат на каждый отрезок пути
            //Построение кучи из затрат на каждом отрезке пути
            //double firstConsump = ConsumptionFunction(this.path[0], this.path[1]);
            //Pair root = new Pair(0,1, firstConsump);
            //this.heapConsumption = new Heap(n - 1, root);
            points[0] = new Pair(path[0]);
            points[n-1] = new Pair(path[n-1]);
            for (int i = 1; i < n - 1; i++)
            {
                double consump = ConsumptionFunction(this.path[i], this.path[i + 1]);
                points[i] = new Pair(path[i], consump);
                //this.heapConsumption.Insert(new Pair(i, i + 1, consump));
            }
            #endregion
            this.heap = new Heap(points);
        }

        private double ConsumptionFunction(DataP3 start, DataP3 finish)
        {
            double coefOfConsumption = ConsumptionCoefficientFunction(start.H, finish.H);
            double consumption = consumptionMin + coefOfConsumption * (finish.H - start.H);
            double distance = Math.Sqrt( Math.Pow((finish.X - start.X),2) + Math.Pow((finish.Y - start.Y),2));

            return distance * consumption;
        }

        private double ConsumptionCoefficientFunction(double h1, double h2)
        {
            if (h2 - h1 > 0) //полет вверх
                return coefOfConsumptionPos;
            else if (h2 - h1 < 0) //полет вниз
                return coefOfConsumptionNeg;
            else
                return 0;
        }

        private bool VariationOfPointWithMaxConsump(int index, bool oldIsInStart = true)
        {
            //TO DO: check formuls

            //create vectors
            double x_a = this.path[index - 1].X - this.path[index].X;
            double y_a = this.path[index - 1].Y - this.path[index].Y;
            double x_b = this.path[index + 1].X - this.path[index].X;
            double y_b = this.path[index + 1].Y - this.path[index].Y;
            //bisector vector
            double x_bisector = 1;
            double y_bisector = 0;

            //if ((x_a * x_b + y_a * y_b) != -1) //if angle is not 180
            if (x_a / x_b != y_a / y_b)
            {
                double lambda = Math.Sqrt(Math.Pow(x_a, 2) + Math.Pow(y_a, 2)) / Math.Sqrt(Math.Pow(x_b, 2) + Math.Pow(y_b, 2));
                x_bisector = (this.path[index - 1].X + lambda * this.path[index + 1].X) / (1 + lambda);
                y_bisector = (this.path[index - 1].Y + lambda * this.path[index + 1].Y) / (1 + lambda);
            }
            else {
                if (x_a != 0)
                {
                    y_bisector = 1;
                    x_bisector = -y_a / x_a;
                }
                else if (y_a != 0)
                {
                    x_bisector = 1;
                    y_bisector = -x_a / y_a;
                }
            }

            DataP3 posVariation, negVariation;
            double x, y, H;

            x = path[index].X + this.hVariation * x_bisector;
            y = path[index].Y + this.hVariation * y_bisector;
            H = this.algorithm.ObjectiveFunc(x, y, this.paramLocal);
            posVariation = new DataP3(x, y, H);

            x = path[index].X - this.hVariation * x_bisector;
            y = path[index].Y - this.hVariation * y_bisector;
            H = this.algorithm.ObjectiveFunc(x, y, this.paramLocal);
            negVariation = new DataP3(x, y, H);

            double posVarConsump = ConsumptionFunction(posVariation, this.path[index + 1]);
            double negVarConsump = ConsumptionFunction(negVariation, this.path[index + 1]);


            // condition for loop exit, if new paths are worse
            if (this.heap.GetMax().getConsumption() < posVarConsump &&
                this.heap.GetMax().getConsumption() < negVarConsump)
            { return false; }

            //change path
            if (posVarConsump < negVarConsump)
            {
                //ChangePath(index, posVariation, posVarConsump, oldIsInStart);
                
                this.path[index] = posVariation;
                //change consumption(priority) for point in heap
                this.heap.ChangePriority(posVarConsump, index);
                
            }
            else
            {
                //ChangePath(index, negVariation, negVarConsump, oldIsInStart);
                
                this.path[index] = negVariation;
                //change consumption(priority) for point in heap
                this.heap.ChangePriority(negVarConsump,index);
            }
            return true;
        }

        public DataP3[] FindPath()
        {
            bool oldIsInStart = true;
            int pointForVariation; // = this.MaxConsumption(ref oldIsInStart);
            bool pathWasChanged = false;
            do
            {
                pointForVariation = this.heap.GetIndexOfMax();
                pathWasChanged = VariationOfPointWithMaxConsump(pointForVariation, oldIsInStart);
            } while (pathWasChanged);

            return this.path;
        }

       /* private void ChangePath(int indexOfOldPoint, DataP3 newPoint, double newConsumption, bool oldIsInStart = true)
        {
            this.path[indexOfOldPoint] = newPoint;
            //change consumption(priority) for point in heap
            this.heapConsumption.ChangePriority(newConsumption);

            int heapIndex = 1;
            double consump;
            if (oldIsInStart)
            {
                int indexPrev = this.heapConsumption.FindPathWithPoint(ref heapIndex, indexOfOldPoint);
                consump = ConsumptionFunction(this.path[indexPrev], this.path[indexOfOldPoint]);

            }
            else
            {
                int indexNext = this.heapConsumption.FindPathWithPoint(ref heapIndex, indexOfOldPoint, false);
                consump = ConsumptionFunction(this.path[indexOfOldPoint], this.path[indexNext]);
            }
            this.heapConsumption.ChangePriority(consump, heapIndex);
        }*/
    }
}