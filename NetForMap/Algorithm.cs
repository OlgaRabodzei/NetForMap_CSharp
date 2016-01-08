using System;

namespace NetForMap
{
    public class Algorithm
    {
        private static Algorithm instance = null;
        private DataP3[] dataPoints;//Исходные точки
        private DataP3[,] targetPoints;//Точки сетки
        private int numDataPoints;//Кол-во исходных точек
        private int type;//Тип весовой ф-ии
        private int paramLocal;

        private PathAlgorithm pathAlgorithm;

        private Algorithm(ref DataP3[] _dataPoints)
        { Init(ref _dataPoints); }

        public void Init(ref DataP3[] _dataPoints)
        {
            this.dataPoints = _dataPoints;
            this.numDataPoints = dataPoints.Length;

            double minX = 0; double maxX = 0;
            double minY = 0; double maxY = 0;
            FindMinMaxCoordinates(ref minX, ref maxX, ref minY, ref maxY);
            double widthNetX = (maxX - minX);
            double widthNetY = (maxY - minY);
            int cellWidth = 1;
            int kx = (int)(widthNetX / cellWidth) + 1;
            int ky = (int)(widthNetY / cellWidth) + 1;
            int numTargetPoints = kx * ky * 4;
            targetPoints = new DataP3[2 * kx, 2 * ky];

            int index = 0;
            for (double i = 0; i < kx; i += 0.5)
            {
                double x = minX + i * cellWidth;
                for (double j = 0; j < ky; j += 0.5)
                {
                    double y = minY + j * cellWidth;
                    targetPoints[(int)(2*i),(int)(2*j)] = new DataP3(x, y, 0);
                    index++;
                }
            }
        }

        public static Algorithm getInstance(ref DataP3[] _dataPoints)
        {
            if (instance == null) instance = new Algorithm(ref _dataPoints);
            return instance;
        }

        public void FindMinMaxCoordinates(ref double minX, ref double maxX, ref double minY, ref double maxY)
        {
            minX = maxX = dataPoints[0].X;
            minY = maxY = dataPoints[0].Y;
            for (int i = 1; i < dataPoints.Length; ++i)
            {
                if (dataPoints[i].X < minX) minX = dataPoints[i].X;
                if (dataPoints[i].X > maxX) maxX = dataPoints[i].X;
                if (dataPoints[i].Y < minY) minY = dataPoints[i].Y;
                if (dataPoints[i].Y > maxY) maxY = dataPoints[i].Y;
            }
        }

        public DataP3[] DataPoints
        { get { return dataPoints; } }

        public DataP3[,] TargetPoints
        { get { return targetPoints; } }

        public void StartAlgorithm()
        {
            this.type = Constants.FuncType;
            this.paramLocal = Constants.ParamLocal;

            for (int i = 0; i < targetPoints.GetLength(0); ++i)
                for (int j = 0; j < targetPoints.GetLength(1); j++)
                    targetPoints[i,j].H = ObjectiveFunc(targetPoints[i,j].X, targetPoints[i,j].Y);
        }

        public double ObjectiveFunc(double x0, double y0) //?!!! public or private?
        {
            double[] a = OLSMethod(x0, y0);
            return a[0];
        }

        private double DotProduct(double[] x, double[] y)
        {
            double res = 0;
            if (x.Length == y.Length)
                for (int i = 0; i < x.Length; i++)
                    res += x[i] * y[i];
            return res;
        }

        private double[] OLSMethod(double x0, double y0)
        {
            int size = 6;
            double[] a = new double[size];
            //составление расширенной матрицы коэффициентов
            double[,] A = new double[size, size + 1];
            for (int k = 0; k < size; k++)
            {
                A[k, 0] = 0;
                for (int m = 1; m < size + 1; m++)
                {
                    A[k, m] = 0;
                    for (int i = 0; i < numDataPoints; i++)
                    {
                        double[] fi = BaseFunctions(x0, y0, dataPoints[i].X, dataPoints[i].Y);
                        double p = WeightingFunc(x0, y0, dataPoints[i].X, dataPoints[i].Y, paramLocal);
                        A[k, m] += fi[k] * fi[m - 1] * p;
                        if (m == 1)
                            A[k, 0] += dataPoints[i].H * fi[k] * p;
                    }
                }
            }
            //Solve system
            MethodGausse(size, ref A, ref a);
            return a;
        }
        /// <summary>
        /// Метод Гаусса
        /// </summary>
        /// <param name="size">Кол-во уравнений</param>
        /// <param name="AugmentedMatrix">Расширенная матрица. Вектор b->a[:,0]</param>
        /// <param name="x">Искомый вектор</param>
        private void MethodGausse(int size, ref double[,] AugmentedMatrix, ref double[] x)
        {
            //прямой ход
            for (int i = 0; i < size; i++)
            {
                if (AugmentedMatrix[i, i + 1] != 1)
                {
                    double koef = AugmentedMatrix[i, i + 1];
                    for (int j = 0; j < size + 1; j++)
                        AugmentedMatrix[i, j] /= koef;//делим строку
                }
                for (int k = i + 1; k < size; k++)
                {
                    double koef = AugmentedMatrix[k, i + 1];
                    for (int j = 0; j < size + 1; j++)
                        AugmentedMatrix[k, j] -= AugmentedMatrix[i, j] * koef;//вычитаем ее из остальных
                }
            }
            //Обратный ход
            for (int k = size - 1; k >= 0; k--)
            {
                x[k] = AugmentedMatrix[k, 0] / AugmentedMatrix[k, k + 1];
                if (k != (size - 1))
                    for (int c = size - 1; c > k; c--)
                        x[k] -= AugmentedMatrix[k, c + 1] * x[c] / AugmentedMatrix[k, k + 1];
            }
        }
        //Множество базовых функций
        private double[] BaseFunctions(double x0, double y0, double X, double Y)
        {
            double[] fi = { 1, X - x0, Y - y0, (X - x0) * (X - x0), (X - x0) * (Y - y0), (Y - y0) * (Y - y0) };
            return fi;
        }
        //Весовая функция
        private double WeightingFunc(double x0, double y0, double X, double Y, int H)
        {
            double d = Math.Sqrt((X - x0) * (X - x0) + (Y - y0) * (Y - y0));
            switch (this.type)
            {
                case 1:
                    { return (double)(1 / (1 + Math.Pow(d, 2) / H * H)); }
                case 2:
                    { return 1 / Math.Sqrt(2 * Math.PI) * Math.Pow(Math.E, -d * d / 2); }
                case 3:
                    { return Math.Pow(Math.E, -Math.Abs(d)); }
                default: return -1;
            }
        }
        //Генерация сетки тестовой поверхности
        public static void GenerateTestSurface(ref DataP3[] surface, int lenght)
        {
            int num = 0;
            for (double i = 0; i < lenght; i += 0.05)
                for (double j = 0; j < lenght; j += 0.05)
                {
                    double z = TestFunc(i, j);
                    surface[num] = new DataP3(i, j, z);
                    num++;
                }
        }
        //Генерация исходных тестовых точек
        public static void GenerateTestData(ref DataP3[] data, int lenght, int max)
        {
            Random r = new Random();
            double x; double y; double z;
            for (int i = 0; i < lenght; i++)
            {
                x = r.NextDouble() * max;
                y = r.NextDouble() * max;
                z = TestFunc(x, y);
                data[i] = new DataP3(x, y, z);
            }
        }
        //Тестовая функция
        private static double TestFunc(double x, double y)
        {
            double t1 = 1 + Math.Pow(x - 6, 2) + Math.Pow(y - 4, 2);
            double t2 = 1 + Math.Pow(x - 3, 2) + Math.Pow(y - 6, 2);
            double t3 = 1 + Math.Pow(x - 7, 2) + Math.Pow(y - 5, 2);
            double t4 = 1 + Math.Pow(x - 2, 2) + Math.Pow(y - 3, 2);
            return (2 / t1 + 3 / t2 + 5 / t3 + 4 / t4);
        }

        public DataP3[] FindPath(float x1, float y1, float x2, float y2)
        {
            DataP3 start = new DataP3(x1,y1, ObjectiveFunc(x1,y1));
            DataP3 finish = new DataP3(x2,y2, ObjectiveFunc(x2,y2));
            this.pathAlgorithm = new PathAlgorithm(start, finish,ref Algorithm.instance);
            return this.pathAlgorithm.FindPath();
        }
    }
}
