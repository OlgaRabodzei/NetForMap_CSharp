using System.Windows.Forms;
using Nevron.GraphicsCore;
using Nevron.Chart;
using Nevron.Chart.Windows;

namespace NetForMap
{
    public partial class _3DSurfaceForm : Form
    {
        private Controller control;
        private DataP3[] data;
        private string dataType;

        public _3DSurfaceForm(DataP3[] _data, string _dataType)
        {
            InitializeComponent();
            control = Controller.getInstance();
            data = _data;
            dataType = _dataType;
            Init();
        }

        private void Init()
        {
            NCartesianChart chart = (NCartesianChart)nChartControl.Charts[0]; //3d график

            NTriangulatedSurfaceSeries surface = new NTriangulatedSurfaceSeries(); //создаём треугольную поверхность
            
            //подключаем зум
            NZoomTool zt = new NZoomTool();
            zt.BeginDragMouseCommand = new NMouseCommand(MouseAction.Wheel, MouseButton.Middle, 0);
            zt.ZoomStep = 20;

            //зум инструмент добавляем в контролу
            nChartControl.Controller.Tools.Add(zt);


            //доп. инструменты подключаем для управления (вращения и приближения)
            nChartControl.Controller.Tools.Add(new NSelectorTool());
            nChartControl.Controller.Tools.Add(new NTrackballTool());

            //очень важная
            nChartControl.Settings.JitterMode = JitterMode.Enabled;
            nChartControl.Settings.JitteringSteps = 1;

            //настройка 3d график
            //включаем поддержку 3d
            chart.Enable3D = true;
            chart.Width = 50;
            chart.Height = 50;
            chart.Depth = 50;
            chart.Projection.SetPredefinedProjection(PredefinedProjection.PerspectiveTilted);


            //добавляем 3d поверхность в 3d график
            chart.Series.Add(surface);

            //настройки для поверхности
            surface.FrameMode = SurfaceFrameMode.Contour;  //сетка или контур
            surface.Name = dataType;  //название графика


            //настройка названия осей
            chart.Axis(StandardAxis.PrimaryY).ScaleConfigurator.Title.Text = "Высота";  //название оси Y
            chart.Axis(StandardAxis.PrimaryX).ScaleConfigurator.Title.Text = "Ширина";   //название оси X
            NStandardScaleConfigurator scale = (NStandardScaleConfigurator)chart.Axis(StandardAxis.PrimaryX).ScaleConfigurator;
            chart.Axis(StandardAxis.Depth).ScaleConfigurator.Title.Text = "Долгота";    //название оси Z
            NStandardScaleConfigurator scaler = (NStandardScaleConfigurator)chart.Axis(StandardAxis.Depth).ScaleConfigurator;

            //заливка поверхности
            surface.FillMode = SurfaceFillMode.Zone;

            AddData(surface);
        }

        private void AddData(NTriangulatedSurfaceSeries surface)
        {
            int n = data.Length;
            for (int i = 0; i < n; i++)
            {
                surface.XValues.Add(data[i].X);
                surface.ZValues.Add(data[i].Y);
                surface.Values.Add(data[i].Z);
            }
        }
    }
}
