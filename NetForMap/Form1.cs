using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetForMap {
    public partial class Form1 : Form {
        Controller control;
        private int type = 2;//Тип весовой функции
        private int paramLocal = 20;//зачение параметра локальности
        private Draw draw;

        public Form1() {
            InitializeComponent();
            control = Controller.getInstance();
            draw = Draw.getInstance(pictureBox);
        }

        private void b_Load_Click(object sender, EventArgs e) {
            openFileDialog.ShowDialog();
        }

        private void b_DrawPoints_Click(object sender, EventArgs e) {
            if (control.DataPoints == null) {
                return;
            }
            using (Graphics graphics = pictureBox.CreateGraphics()) {
                float kx = 1; float ky = 1;
                Scale(ref kx,ref ky);
                graphics.ScaleTransform(kx, ky);

                Pen pen = new Pen(Color.Blue, 0.0f);
                foreach (DataP3 p in control.DataPoints)
                    graphics.DrawEllipse(pen, (float)p.X, (float)p.Y, 0.05f, 0.05f);
            }

        }

        private void b_FindAndDrawNet_Click(object sender, EventArgs e) {
            if (control.DataPoints == null) {
                return;
            }
            // Find net
            control.StartAlgorithm(type, paramLocal);
            // Draw net
            if (control.TargetPoints == null) {
                return;
            }
            using (Graphics graphics = pictureBox.CreateGraphics()) {
                float kx = 1; float ky = 1;
                Scale(ref kx, ref ky);
                graphics.ScaleTransform(kx, ky);

                Pen pen = new Pen(Color.Red, 0.0f);
                foreach (DataP3 p in control.TargetPoints)
                    graphics.DrawEllipse(pen, (float)p.X, (float)p.Y, 0.05f, 0.05f);

                draw.SetScale(kx, ky);
                draw.DrawAllIsolines(control.TargetPoints);
            }
            b_Surface.Enabled = true;
            b_FindAndDrawPath.Enabled = true;
        }

        private void b_FindAndDrawPath_Click(object sender, EventArgs e) {
            control.FindPath(1, 2, 8, 5);
            draw.DrawPath(control.GetLastPath());
        }

        private void b_Clear_Click(object sender, EventArgs e) {
            pictureBox.Refresh();
        }

        private void b_Surface_Click(object sender, EventArgs e) {
            if (control.TargetPoints != null) {
                _3DSurfaceForm surface = new _3DSurfaceForm(control.TargetPoints, "Created surface");
                surface.Show();
            }
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e) {
            string fileName = openFileDialog.FileName;
            control.LoadData(fileName);
            if (control.DataPoints != null) {
                b_DrawPoints.Enabled = true;
                b_FindAndDrawNet.Enabled = true;
                b_Clear.Enabled = true;
            }
        }

        private void Scale(ref float kx, ref float ky) {
            double minX = 0;
            double maxX = 0;
            double minY = 0;
            double maxY = 0;
            control.FindMinMaxCoordinates(ref minX, ref maxX, ref minY, ref maxY);

            kx = (float)(pictureBox.Width / (maxX + 1));
            ky = (float)(pictureBox.Height / (maxY + 1));
        }

        private void pathToolStripMenuItem_Click(object sender, EventArgs e) {
            PathAlgorithmSettingsForm pathSettings = new PathAlgorithmSettingsForm();
            pathSettings.Show(this);
        }
    }
}
