using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetForMap {
    public partial class PathAlgorithmSettingsForm : Form {
        public PathAlgorithmSettingsForm() {
            InitializeComponent();
            SetDefaultValues();
        }

        private void SetDefaultValues() {
            numUD_numberOfPoints.Value = Constants.PathPointsNum;
            numUD_consumpStand.Value = Convert.ToDecimal( Constants.ConsumpStand);
            numUD_consumpPos.Value = Convert.ToDecimal(Constants.ConsumpPos);
            numUD_consumpNeg.Value = Convert.ToDecimal(Constants.ConsumpNeg);
            numUD_varDistance.Value =  Convert.ToDecimal(Constants.VariationDist);
        }

        private void numUD_numberOfPoints_ValueChanged(object sender, EventArgs e) {
            Constants.PathPointsNum = Convert.ToInt32(numUD_numberOfPoints.Value);
        }

        private void numUD_consumpStand_ValueChanged(object sender, EventArgs e) {
            Constants.ConsumpStand = Convert.ToDouble(numUD_consumpStand.Value);
            trB_consumpStand.Value = Convert.ToInt32(numUD_consumpStand.Value);
        }

        private void numUD_consumpPos_ValueChanged(object sender, EventArgs e) {
            Constants.ConsumpPos = Convert.ToDouble(numUD_consumpPos.Value);
            trB_consumpPos.Value = Convert.ToInt32(numUD_consumpPos.Value);
        }

        private void numUD_consumpNeg_ValueChanged(object sender, EventArgs e) {
            Constants.ConsumpNeg = Convert.ToDouble(numUD_consumpNeg.Value);
            trB_consumpNeg.Value = Convert.ToInt32(numUD_consumpNeg.Value);
        }

        private void numUD_varDistance_ValueChanged(object sender, EventArgs e) {
            Constants.VariationDist = Convert.ToDouble(numUD_varDistance.Value);
            trB_varDistance.Value = Convert.ToInt32(Convert.ToDouble(numUD_varDistance.Value) / 0.1);
        }

        private void trB_consumpStand_Scroll(object sender, EventArgs e) {
            numUD_consumpStand.Value = trB_consumpStand.Value;
        }

        private void trB_consumpPos_Scroll(object sender, EventArgs e) {
            numUD_consumpPos.Value = trB_consumpPos.Value;
        }

        private void trB_consumpNeg_Scroll(object sender, EventArgs e) {
            numUD_consumpNeg.Value = trB_consumpNeg.Value;
        }

        private void trB_varDistance_Scroll(object sender, EventArgs e) {
            numUD_varDistance.Value = Convert.ToDecimal(trB_varDistance.Value * 0.1);
        }
    }
}
