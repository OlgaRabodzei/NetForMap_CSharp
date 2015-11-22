using System;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;

namespace NetForMap
{
    public class FileManager
    {
        private static FileManager instance;
        private Excel.Application _application = null;
        private Excel.Workbook _workBook = null;
        private Excel.Worksheet _workSheet = null;
        private object _missingObj = System.Reflection.Missing.Value;

        private FileManager() { }

        public static FileManager getInstance()
        {
            if (instance == null) instance = new FileManager();
            return instance;
        }

        private void Init(String fileName)
        {
            _application = new Excel.Application();//открыть эксель
            _workBook = _application.Workbooks.Open(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); //открыть файл
            _workSheet = (Excel.Worksheet)_workBook.Worksheets[1];//получить 1 лист
        }

        public void Close()
        {
            if (_application != null)
            {
                _workBook.Close(true, _missingObj, _missingObj);
                _application.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(_application);
                _application = null;
                _workBook = null;
                _workSheet = null;
                System.GC.Collect();
            }
        }

        public DataP3[] Read(String fileName)
        {
            Init(fileName);
            List<DataP3> Points = new List<DataP3>();

            var lastCell = _workSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);//1 ячейку
            for (int i = 2; i < lastCell.Row + 1; i++) // по всем строкам
            {
                double x = double.Parse(_workSheet.Cells[i, 1].Text.ToString());
                double y = double.Parse(_workSheet.Cells[i, 2].Text.ToString());
                double z = double.Parse(_workSheet.Cells[i, 3].Text.ToString());
                Points.Add(new DataP3(x, y, z));
            }
            Close();
            return Points.ToArray();
        }
        /// <summary>
        /// Запись в файл
        /// </summary>
        /// <param name="dataPoints">Исходные точки</param>
        /// <param name="targetPoints">Точки регулярной сетки</param>
        /// <param name="fileName">Имя файла записи</param>
        public void Write(ref DataP3[] dataPoints, ref DataP3[,] targetPoints, string fileName)
        {
            Init(fileName);
            if (dataPoints.Length != 0)
            {
                _workSheet.Cells[1, 1] = "X";
                _workSheet.Cells[1, 2] = "Y";
                _workSheet.Cells[1, 3] = "H";
                for (int i = 0; i < dataPoints.Length; i++) // по всем строкам
                {
                    _workSheet.Cells[i + 2, 1] = dataPoints[i].X;
                    _workSheet.Cells[i + 2, 2] = dataPoints[i].Y;
                    _workSheet.Cells[i + 2, 3] = dataPoints[i].H;
                }
            }
            if (targetPoints.Length != 0)
            {
                _workSheet = _workSheet.Next;
                _workSheet.Cells[1, 1] = "X";
                _workSheet.Cells[1, 2] = "Y";
                _workSheet.Cells[1, 3] = "H";
                int indexCell = 2;
                for (int i = 0; i < targetPoints.GetLength(0); i++) // по всем строкам
                    for (int j = 0; j < targetPoints.GetLength(1); j++)
                    {
                        _workSheet.Cells[indexCell, 1] = targetPoints[i,j].X;
                        _workSheet.Cells[indexCell, 2] = targetPoints[i,j].Y;
                        _workSheet.Cells[indexCell, 3] = targetPoints[i,j].H;
                        indexCell++;
                    }
            }
            _application.Visible = true;//открываем файл
        }

        // Видимость документа
        public bool Visible
        {
            get { return _application.Visible; }
            set { _application.Visible = value; }
        }
    }
}
