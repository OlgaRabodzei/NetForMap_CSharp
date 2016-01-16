using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetForMap {
    public partial class SetPointsForm : Form {
        public SetPointsForm() {
            InitializeComponent();
        }

        private void b_setCoordinates_Click(object sender, EventArgs e) {
            float x1 = float.Parse(tB_startX.Text);
            float y1 = float.Parse(tB_startY.Text);
            float x2 = float.Parse(tB_finishX.Text);
            float y2 = float.Parse(tB_finishY.Text);

            Controller.getInstance().FindPath(x1,y1,x2,y2);
            this.Close();
        }
    }
}
