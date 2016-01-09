using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetForMap {
    public partial class AlgorithmSettingsForm : Form {
        public AlgorithmSettingsForm() {
            InitializeComponent();
            SetDefaultValues();
        }

        private void SetDefaultValues() {
            switch (Constants.FuncType) {
                case 1: rB_func1.Checked = true; break;
                case 2: rB_func2.Checked = true; break;
                case 3: rB_func3.Checked = true; break;
            }
            numUD_localParam.Value = Convert.ToDecimal(Constants.ParamLocal);
        }

        private void rB_func1_CheckedChanged(object sender, EventArgs e) {
            if (rB_func1.Checked) Constants.FuncType = 1;
        }

        private void rB_func2_CheckedChanged(object sender, EventArgs e) {
            if (rB_func2.Checked) Constants.FuncType = 2;
        }

        private void rB_func3_CheckedChanged(object sender, EventArgs e) {
            if (rB_func3.Checked) Constants.FuncType = 3;
        }

        private void numUD_localParam_ValueChanged(object sender, EventArgs e) {
            Constants.ParamLocal = Convert.ToInt32(numUD_localParam.Value);
        }
    }
}
