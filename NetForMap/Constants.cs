using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetForMap {
    public static class Constants {
        #region General Algorithm
        public static int ParamLocal { get; set; }
        public static int FuncType { get; set; }
        #endregion

        #region Path Algorithm
        public static int PathPointsNum { get; set; }
        #region Consumption
        public static double ConsumpStand { get; set; }
        public static double ConsumpPos { get; set; }
        public static double ConsumpNeg { get; set; }
        #endregion
        public static double VariationDist { get; set; }
        #endregion
    }
}
