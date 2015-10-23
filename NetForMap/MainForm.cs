using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NetForMap
{
    public partial class MainForm : Form
    {
        Controller control;
        private int type = 1;//Тип весовой функции
        private int paramLocal = 20;//зачение параметра локальности

        public MainForm()
        { InitializeComponent(); control = Controller.getInstance(); }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = openFileDialog1.FileName;
            control.LoadData(fileName);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e) { }

        private void загрузитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        { openFileDialog1.ShowDialog(); }

        private void сохранитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                control.SaveData(fileName, true, false);
            }
        }

        private void сохранитьРезультатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                control.SaveData(fileName, false, true);
            }
        }

        private void соханитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (DialogResult == DialogResult.OK || DialogResult == DialogResult.None)//none?
            {
                string fileName = saveFileDialog1.FileName;
                control.SaveData(fileName, true, true);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        { control.CloseIOStream(); Close(); }

        private void сгенерироватьТестовуюПоверхностьToolStripMenuItem_Click(object sender, EventArgs e)
        { control.GenerateTestSurface(); }

        private void сгенерироватьТестовыеДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        { control.GenerateTestData(); }

        private void вычислитьРегулярнуюСеткуToolStripMenuItem_Click(object sender, EventArgs e)
        { control.StartAlgorithm(type, paramLocal); }

        private void отобразитьТочкиНаПлоскостиToolStripMenuItem_Click(object sender, EventArgs e)
        { pictureBox.Invalidate(); }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (control.TargetPoints != null || control.DataPoints != null)
            {
                float kx = 1; float ky = 1;
                Scale(ref kx, ref ky);
                e.Graphics.ScaleTransform(kx, ky);
            }
            if (control.TargetPoints != null)
            {
                Pen pen = new Pen(Color.Red, 0.0f);
                foreach (DataP3 p in control.TargetPoints)
                    e.Graphics.DrawEllipse(pen, (float)p.X, (float)p.Y, 0.05f, 0.05f);
            }
            if (control.DataPoints != null)
            {
                Pen pen = new Pen(Color.Blue, 0.0f);
                foreach (DataP3 p in control.DataPoints)
                    e.Graphics.DrawEllipse(pen, (float)p.X, (float)p.Y, 0.05f, 0.05f);
            }
        }

        private void Scale(ref float kx, ref float ky)
        {
            double minX = 0;
            double maxX = 0;
            double minY = 0;
            double maxY = 0;
            control.FindMinMaxCoordinates(ref minX, ref maxX, ref minY, ref maxY);

            kx = (float)(pictureBox.Width / (maxX + 1));
            ky = (float)(pictureBox.Height / (maxY + 1));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        { if (radioButton1.Checked) type = 1; }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        { if (radioButton2.Checked) type = 2; }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        { if (radioButton3.Checked) type = 3; }

        private void тестоваяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (control.TestSurface != null)
            {
                _3DSurfaceForm surface = new _3DSurfaceForm(control.TestSurface, "Тестовая поверхность");
                surface.Show();
            }
        }

        private void построеннаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (control.TargetPoints != null)
            {
                _3DSurfaceForm surface = new _3DSurfaceForm(control.TargetPoints, "Построенная поверхность");
                surface.Show();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        { paramLocal = (int)numericUpDown1.Value; }
    }
}
