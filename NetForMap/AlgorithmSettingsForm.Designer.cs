namespace NetForMap {
    partial class AlgorithmSettingsForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.rB_func1 = new System.Windows.Forms.RadioButton();
            this.rB_func2 = new System.Windows.Forms.RadioButton();
            this.rB_func3 = new System.Windows.Forms.RadioButton();
            this.numUD_localParam = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_localParam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local function";
            // 
            // rB_func1
            // 
            this.rB_func1.AutoSize = true;
            this.rB_func1.Location = new System.Drawing.Point(78, 47);
            this.rB_func1.Name = "rB_func1";
            this.rB_func1.Size = new System.Drawing.Size(85, 17);
            this.rB_func1.TabIndex = 2;
            this.rB_func1.TabStop = true;
            this.rB_func1.Text = "radioButton1";
            this.rB_func1.UseVisualStyleBackColor = true;
            this.rB_func1.CheckedChanged += new System.EventHandler(this.rB_func1_CheckedChanged);
            // 
            // rB_func2
            // 
            this.rB_func2.AutoSize = true;
            this.rB_func2.Location = new System.Drawing.Point(78, 85);
            this.rB_func2.Name = "rB_func2";
            this.rB_func2.Size = new System.Drawing.Size(85, 17);
            this.rB_func2.TabIndex = 3;
            this.rB_func2.TabStop = true;
            this.rB_func2.Text = "radioButton2";
            this.rB_func2.UseVisualStyleBackColor = true;
            this.rB_func2.CheckedChanged += new System.EventHandler(this.rB_func2_CheckedChanged);
            // 
            // rB_func3
            // 
            this.rB_func3.AutoSize = true;
            this.rB_func3.Location = new System.Drawing.Point(78, 127);
            this.rB_func3.Name = "rB_func3";
            this.rB_func3.Size = new System.Drawing.Size(85, 17);
            this.rB_func3.TabIndex = 4;
            this.rB_func3.TabStop = true;
            this.rB_func3.Text = "radioButton3";
            this.rB_func3.UseVisualStyleBackColor = true;
            this.rB_func3.CheckedChanged += new System.EventHandler(this.rB_func3_CheckedChanged);
            // 
            // numUD_localParam
            // 
            this.numUD_localParam.Location = new System.Drawing.Point(66, 193);
            this.numUD_localParam.Name = "numUD_localParam";
            this.numUD_localParam.Size = new System.Drawing.Size(120, 20);
            this.numUD_localParam.TabIndex = 5;
            this.numUD_localParam.ValueChanged += new System.EventHandler(this.numUD_localParam_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(65, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Local parameter";
            // 
            // AlgorithmSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 227);
            this.Controls.Add(this.numUD_localParam);
            this.Controls.Add(this.rB_func3);
            this.Controls.Add(this.rB_func2);
            this.Controls.Add(this.rB_func1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AlgorithmSettingsForm";
            this.Text = "AlgorithmSettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.numUD_localParam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rB_func1;
        private System.Windows.Forms.RadioButton rB_func2;
        private System.Windows.Forms.RadioButton rB_func3;
        private System.Windows.Forms.NumericUpDown numUD_localParam;
        private System.Windows.Forms.Label label2;
    }
}