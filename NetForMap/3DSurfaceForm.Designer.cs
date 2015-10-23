namespace NetForMap
{
    partial class _3DSurfaceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_3DSurfaceForm));
            this.nChartControl = new Nevron.Chart.WinForm.NChartControl();
            this.SuspendLayout();
            // 
            // nChartControl
            // 
            this.nChartControl.AutoRefresh = false;
            this.nChartControl.BackColor = System.Drawing.SystemColors.Control;
            this.nChartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nChartControl.InputKeys = new System.Windows.Forms.Keys[0];
            this.nChartControl.Location = new System.Drawing.Point(0, 0);
            this.nChartControl.Name = "nChartControl";
            this.nChartControl.Size = new System.Drawing.Size(666, 513);
            this.nChartControl.State = ((Nevron.Chart.WinForm.NState)(resources.GetObject("nChartControl.State")));
            this.nChartControl.TabIndex = 0;
            this.nChartControl.Text = "nChartControl1";
            // 
            // _3DSurfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 513);
            this.Controls.Add(this.nChartControl);
            this.Name = "_3DSurfaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_3DSurfaceForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Nevron.Chart.WinForm.NChartControl nChartControl;

    }
}