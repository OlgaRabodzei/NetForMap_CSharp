namespace NetForMap {
    partial class PathAlgorithmSettingsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox_General = new System.Windows.Forms.GroupBox();
            this.numUD_numberOfPoints = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Fuel = new System.Windows.Forms.GroupBox();
            this.trB_consumpNeg = new System.Windows.Forms.TrackBar();
            this.trB_consumpPos = new System.Windows.Forms.TrackBar();
            this.trB_consumpStand = new System.Windows.Forms.TrackBar();
            this.numUD_consumpNeg = new System.Windows.Forms.NumericUpDown();
            this.numUD_consumpPos = new System.Windows.Forms.NumericUpDown();
            this.numUD_consumpStand = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_Variation = new System.Windows.Forms.GroupBox();
            this.trB_varDistance = new System.Windows.Forms.TrackBar();
            this.numUD_varDistance = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_General.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_numberOfPoints)).BeginInit();
            this.groupBox_Fuel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trB_consumpNeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trB_consumpPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trB_consumpStand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_consumpNeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_consumpPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_consumpStand)).BeginInit();
            this.groupBox_Variation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trB_varDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_varDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_General
            // 
            this.groupBox_General.Controls.Add(this.numUD_numberOfPoints);
            this.groupBox_General.Controls.Add(this.label1);
            this.groupBox_General.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_General.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_General.Location = new System.Drawing.Point(0, 0);
            this.groupBox_General.Name = "groupBox_General";
            this.groupBox_General.Size = new System.Drawing.Size(440, 75);
            this.groupBox_General.TabIndex = 0;
            this.groupBox_General.TabStop = false;
            this.groupBox_General.Text = "General";
            // 
            // numUD_numberOfPoints
            // 
            this.numUD_numberOfPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUD_numberOfPoints.Location = new System.Drawing.Point(238, 27);
            this.numUD_numberOfPoints.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUD_numberOfPoints.Name = "numUD_numberOfPoints";
            this.numUD_numberOfPoints.Size = new System.Drawing.Size(120, 20);
            this.numUD_numberOfPoints.TabIndex = 1;
            this.numUD_numberOfPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUD_numberOfPoints.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUD_numberOfPoints.ValueChanged += new System.EventHandler(this.numUD_numberOfPoints_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "The number of partition points of the path";
            // 
            // groupBox_Fuel
            // 
            this.groupBox_Fuel.Controls.Add(this.trB_consumpNeg);
            this.groupBox_Fuel.Controls.Add(this.trB_consumpPos);
            this.groupBox_Fuel.Controls.Add(this.trB_consumpStand);
            this.groupBox_Fuel.Controls.Add(this.numUD_consumpNeg);
            this.groupBox_Fuel.Controls.Add(this.numUD_consumpPos);
            this.groupBox_Fuel.Controls.Add(this.numUD_consumpStand);
            this.groupBox_Fuel.Controls.Add(this.label4);
            this.groupBox_Fuel.Controls.Add(this.label3);
            this.groupBox_Fuel.Controls.Add(this.label2);
            this.groupBox_Fuel.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Fuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Fuel.Location = new System.Drawing.Point(0, 75);
            this.groupBox_Fuel.Name = "groupBox_Fuel";
            this.groupBox_Fuel.Size = new System.Drawing.Size(440, 322);
            this.groupBox_Fuel.TabIndex = 1;
            this.groupBox_Fuel.TabStop = false;
            this.groupBox_Fuel.Text = "Fuel Consumption";
            // 
            // trB_consumpNeg
            // 
            this.trB_consumpNeg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trB_consumpNeg.Location = new System.Drawing.Point(15, 243);
            this.trB_consumpNeg.Maximum = 100;
            this.trB_consumpNeg.Name = "trB_consumpNeg";
            this.trB_consumpNeg.Size = new System.Drawing.Size(421, 45);
            this.trB_consumpNeg.TabIndex = 8;
            this.trB_consumpNeg.TickFrequency = 5;
            this.trB_consumpNeg.Scroll += new System.EventHandler(this.trB_consumpNeg_Scroll);
            // 
            // trB_consumpPos
            // 
            this.trB_consumpPos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trB_consumpPos.Location = new System.Drawing.Point(15, 147);
            this.trB_consumpPos.Maximum = 100;
            this.trB_consumpPos.Name = "trB_consumpPos";
            this.trB_consumpPos.Size = new System.Drawing.Size(421, 45);
            this.trB_consumpPos.TabIndex = 7;
            this.trB_consumpPos.TickFrequency = 5;
            this.trB_consumpPos.Scroll += new System.EventHandler(this.trB_consumpPos_Scroll);
            // 
            // trB_consumpStand
            // 
            this.trB_consumpStand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trB_consumpStand.Location = new System.Drawing.Point(15, 60);
            this.trB_consumpStand.Maximum = 100;
            this.trB_consumpStand.Name = "trB_consumpStand";
            this.trB_consumpStand.Size = new System.Drawing.Size(421, 45);
            this.trB_consumpStand.TabIndex = 6;
            this.trB_consumpStand.TickFrequency = 5;
            this.trB_consumpStand.Scroll += new System.EventHandler(this.trB_consumpStand_Scroll);
            // 
            // numUD_consumpNeg
            // 
            this.numUD_consumpNeg.DecimalPlaces = 1;
            this.numUD_consumpNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUD_consumpNeg.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUD_consumpNeg.Location = new System.Drawing.Point(238, 212);
            this.numUD_consumpNeg.Name = "numUD_consumpNeg";
            this.numUD_consumpNeg.Size = new System.Drawing.Size(120, 20);
            this.numUD_consumpNeg.TabIndex = 5;
            this.numUD_consumpNeg.ValueChanged += new System.EventHandler(this.numUD_consumpNeg_ValueChanged);
            // 
            // numUD_consumpPos
            // 
            this.numUD_consumpPos.DecimalPlaces = 1;
            this.numUD_consumpPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUD_consumpPos.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUD_consumpPos.Location = new System.Drawing.Point(238, 119);
            this.numUD_consumpPos.Name = "numUD_consumpPos";
            this.numUD_consumpPos.Size = new System.Drawing.Size(120, 20);
            this.numUD_consumpPos.TabIndex = 4;
            this.numUD_consumpPos.ValueChanged += new System.EventHandler(this.numUD_consumpPos_ValueChanged);
            // 
            // numUD_consumpStand
            // 
            this.numUD_consumpStand.DecimalPlaces = 1;
            this.numUD_consumpStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUD_consumpStand.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUD_consumpStand.Location = new System.Drawing.Point(238, 33);
            this.numUD_consumpStand.Name = "numUD_consumpStand";
            this.numUD_consumpStand.Size = new System.Drawing.Size(120, 20);
            this.numUD_consumpStand.TabIndex = 3;
            this.numUD_consumpStand.ValueChanged += new System.EventHandler(this.numUD_consumpStand_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(121, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Flying Down";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(121, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Flying Up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(121, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Standart";
            // 
            // groupBox_Variation
            // 
            this.groupBox_Variation.Controls.Add(this.trB_varDistance);
            this.groupBox_Variation.Controls.Add(this.numUD_varDistance);
            this.groupBox_Variation.Controls.Add(this.label5);
            this.groupBox_Variation.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Variation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Variation.Location = new System.Drawing.Point(0, 397);
            this.groupBox_Variation.Name = "groupBox_Variation";
            this.groupBox_Variation.Size = new System.Drawing.Size(440, 114);
            this.groupBox_Variation.TabIndex = 2;
            this.groupBox_Variation.TabStop = false;
            this.groupBox_Variation.Text = "Point Variation";
            // 
            // trB_varDistance
            // 
            this.trB_varDistance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trB_varDistance.Location = new System.Drawing.Point(15, 54);
            this.trB_varDistance.Name = "trB_varDistance";
            this.trB_varDistance.Size = new System.Drawing.Size(421, 45);
            this.trB_varDistance.TabIndex = 11;
            this.trB_varDistance.Scroll += new System.EventHandler(this.trB_varDistance_Scroll);
            // 
            // numUD_varDistance
            // 
            this.numUD_varDistance.DecimalPlaces = 2;
            this.numUD_varDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUD_varDistance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUD_varDistance.Location = new System.Drawing.Point(238, 28);
            this.numUD_varDistance.Name = "numUD_varDistance";
            this.numUD_varDistance.Size = new System.Drawing.Size(120, 20);
            this.numUD_varDistance.TabIndex = 10;
            this.numUD_varDistance.ValueChanged += new System.EventHandler(this.numUD_varDistance_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(121, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Shift distance";
            // 
            // PathAlgorithmSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 517);
            this.Controls.Add(this.groupBox_Variation);
            this.Controls.Add(this.groupBox_Fuel);
            this.Controls.Add(this.groupBox_General);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PathAlgorithmSettingsForm";
            this.Text = "PathAlgorithmSettingsForm";
            this.groupBox_General.ResumeLayout(false);
            this.groupBox_General.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_numberOfPoints)).EndInit();
            this.groupBox_Fuel.ResumeLayout(false);
            this.groupBox_Fuel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trB_consumpNeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trB_consumpPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trB_consumpStand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_consumpNeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_consumpPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_consumpStand)).EndInit();
            this.groupBox_Variation.ResumeLayout(false);
            this.groupBox_Variation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trB_varDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_varDistance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_General;
        private System.Windows.Forms.GroupBox groupBox_Fuel;
        private System.Windows.Forms.GroupBox groupBox_Variation;
        private System.Windows.Forms.NumericUpDown numUD_numberOfPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trB_consumpNeg;
        private System.Windows.Forms.TrackBar trB_consumpPos;
        private System.Windows.Forms.TrackBar trB_consumpStand;
        private System.Windows.Forms.NumericUpDown numUD_consumpNeg;
        private System.Windows.Forms.NumericUpDown numUD_consumpPos;
        private System.Windows.Forms.NumericUpDown numUD_consumpStand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trB_varDistance;
        private System.Windows.Forms.NumericUpDown numUD_varDistance;
        private System.Windows.Forms.Label label5;
    }
}