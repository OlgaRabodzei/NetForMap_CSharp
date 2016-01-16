namespace NetForMap
{
    public class Controller
    {
        private static Controller instance;
        private FileManager fileManager;
        private Algorithm algorithm;
        private DataP3[] dataPoints;
        private DataP3[,] targetPoints;
        private DataP3[] testSurface;
        private DataP3[] lastPath;

        private Controller() { SetDefaultValues(); }

        public static Controller getInstance()
        {
            if (instance == null) instance = new Controller();
            return instance;
        }

        private void SetDefaultValues() {
            Constants.FuncType = 2;
            Constants.ParamLocal = 20;
            Constants.PathPointsNum = 10;
            Constants.ConsumpStand = 2;
            Constants.ConsumpPos = 5;
            Constants.ConsumpNeg = 20;
            Constants.VariationDist = 0.25;
        }

        public DataP3[] DataPoints
        { get { return dataPoints; } }

        public DataP3[,] TargetPoints
        { get { return targetPoints; } }

        public DataP3[] TestSurface
        { get { return testSurface; } }

        public void LoadData(string fileName)
        {
            Clear();
            fileManager = FileManager.getInstance();
            dataPoints = fileManager.Read(fileName);
            if (algorithm == null)
                algorithm = Algorithm.getInstance(ref dataPoints);
            else
                algorithm.Init(ref dataPoints);
        }

        public void SaveData(string fileName, bool saveData, bool saveResult)
        {
            fileManager = FileManager.getInstance();
            if (saveData && saveResult)
                fileManager.Write(ref dataPoints, ref targetPoints, fileName);
            else if (saveData)
            {
                DataP3[,] NULL = new DataP3[0,0];
                fileManager.Write(ref dataPoints, ref NULL, fileName);
            }
            else if (saveResult)
            {
                DataP3[] NULL = new DataP3[0];
                fileManager.Write(ref NULL, ref targetPoints, fileName);
            }
        }

        public void CloseIOStream()
        {
            fileManager = FileManager.getInstance();
            fileManager.Close();
        }

        public void StartAlgorithm()
        {
            if (algorithm != null)
            {
                algorithm.StartAlgorithm();
                targetPoints = algorithm.TargetPoints;
            }
        }

        public void FindMinMaxCoordinates(ref double minX, ref double maxX, ref double minY, ref double maxY)
        { DataP3.FindMinMaxCoordinates(dataPoints,ref minX, ref maxX, ref minY, ref maxY); }

        public void GenerateTestSurface()
        {
            int lenght = 10;
            int numDataPoints = lenght * lenght * 400;
            testSurface = new DataP3[numDataPoints];
            Algorithm.GenerateTestSurface(ref testSurface, lenght);
        }

        public void GenerateTestData()
        {
            Clear();
            int lenght = 100;//--******!!
            int max = 10;
            dataPoints = new DataP3[lenght];
            Algorithm.GenerateTestData(ref dataPoints, lenght, max);
            if (algorithm == null)
                algorithm = Algorithm.getInstance(ref dataPoints);
            else
                algorithm.Init(ref dataPoints);
        }

        private void Clear()
        { dataPoints = null; targetPoints = null; }


        public void FindPath(float x1, float y1, float x2, float y2)
        {
            this.lastPath = this.algorithm.FindPath(x1,y1,x2,y2);
        }

        public DataP3[] GetLastPath() { return this.lastPath; }
    }
}
