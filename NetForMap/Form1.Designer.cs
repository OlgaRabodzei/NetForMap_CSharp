namespace NetForMap
{
    partial class Form1
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
            this.b_Load = new System.Windows.Forms.Button();
            this.b_DrawPoints = new System.Windows.Forms.Button();
            this.b_FindAndDrawNet = new System.Windows.Forms.Button();
            this.b_FindAndDrawPath = new System.Windows.Forms.Button();
            this.b_Clear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadRegularNetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveGeneratedDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRegularNetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regularNetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b_Surface = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // b_Load
            // 
            this.b_Load.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_Load.Location = new System.Drawing.Point(0, 24);
            this.b_Load.Name = "b_Load";
            this.b_Load.Size = new System.Drawing.Size(704, 30);
            this.b_Load.TabIndex = 0;
            this.b_Load.Text = "Load data";
            this.b_Load.UseVisualStyleBackColor = true;
            this.b_Load.Click += new System.EventHandler(this.b_Load_Click);
            // 
            // b_DrawPoints
            // 
            this.b_DrawPoints.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_DrawPoints.Enabled = false;
            this.b_DrawPoints.Location = new System.Drawing.Point(0, 54);
            this.b_DrawPoints.Name = "b_DrawPoints";
            this.b_DrawPoints.Size = new System.Drawing.Size(704, 30);
            this.b_DrawPoints.TabIndex = 1;
            this.b_DrawPoints.Text = "Draw loaded points";
            this.b_DrawPoints.UseVisualStyleBackColor = true;
            this.b_DrawPoints.Click += new System.EventHandler(this.b_DrawPoints_Click);
            // 
            // b_FindAndDrawNet
            // 
            this.b_FindAndDrawNet.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_FindAndDrawNet.Enabled = false;
            this.b_FindAndDrawNet.Location = new System.Drawing.Point(0, 84);
            this.b_FindAndDrawNet.Name = "b_FindAndDrawNet";
            this.b_FindAndDrawNet.Size = new System.Drawing.Size(704, 30);
            this.b_FindAndDrawNet.TabIndex = 2;
            this.b_FindAndDrawNet.Text = "Find and draw regular net";
            this.b_FindAndDrawNet.UseVisualStyleBackColor = true;
            this.b_FindAndDrawNet.Click += new System.EventHandler(this.b_FindAndDrawNet_Click);
            // 
            // b_FindAndDrawPath
            // 
            this.b_FindAndDrawPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_FindAndDrawPath.Enabled = false;
            this.b_FindAndDrawPath.Location = new System.Drawing.Point(0, 114);
            this.b_FindAndDrawPath.Name = "b_FindAndDrawPath";
            this.b_FindAndDrawPath.Size = new System.Drawing.Size(704, 30);
            this.b_FindAndDrawPath.TabIndex = 3;
            this.b_FindAndDrawPath.Text = "Find and draw path";
            this.b_FindAndDrawPath.UseVisualStyleBackColor = true;
            this.b_FindAndDrawPath.Click += new System.EventHandler(this.b_FindAndDrawPath_Click);
            // 
            // b_Clear
            // 
            this.b_Clear.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_Clear.Enabled = false;
            this.b_Clear.Location = new System.Drawing.Point(0, 144);
            this.b_Clear.Name = "b_Clear";
            this.b_Clear.Size = new System.Drawing.Size(704, 30);
            this.b_Clear.TabIndex = 4;
            this.b_Clear.Text = "Clear field";
            this.b_Clear.UseVisualStyleBackColor = true;
            this.b_Clear.Click += new System.EventHandler(this.b_Clear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDataToolStripMenuItem,
            this.loadRegularNetToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveGeneratedDataToolStripMenuItem,
            this.saveRegularNetToolStripMenuItem,
            this.savePathToolStripMenuItem,
            this.saveAllToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadDataToolStripMenuItem
            // 
            this.loadDataToolStripMenuItem.Name = "loadDataToolStripMenuItem";
            this.loadDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadDataToolStripMenuItem.Text = "Load data";
            // 
            // loadRegularNetToolStripMenuItem
            // 
            this.loadRegularNetToolStripMenuItem.Name = "loadRegularNetToolStripMenuItem";
            this.loadRegularNetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadRegularNetToolStripMenuItem.Text = "Load regular net";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // saveGeneratedDataToolStripMenuItem
            // 
            this.saveGeneratedDataToolStripMenuItem.Name = "saveGeneratedDataToolStripMenuItem";
            this.saveGeneratedDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveGeneratedDataToolStripMenuItem.Text = "Save generated data";
            // 
            // saveRegularNetToolStripMenuItem
            // 
            this.saveRegularNetToolStripMenuItem.Name = "saveRegularNetToolStripMenuItem";
            this.saveRegularNetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveRegularNetToolStripMenuItem.Text = "Save regular net";
            // 
            // savePathToolStripMenuItem
            // 
            this.savePathToolStripMenuItem.Name = "savePathToolStripMenuItem";
            this.savePathToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.savePathToolStripMenuItem.Text = "Save path";
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAllToolStripMenuItem.Text = "Save all";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regularNetToolStripMenuItem,
            this.pathToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.settingsToolStripMenuItem.Text = "Algorithm Settings";
            // 
            // regularNetToolStripMenuItem
            // 
            this.regularNetToolStripMenuItem.Name = "regularNetToolStripMenuItem";
            this.regularNetToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.regularNetToolStripMenuItem.Text = "Regular net";
            // 
            // pathToolStripMenuItem
            // 
            this.pathToolStripMenuItem.Name = "pathToolStripMenuItem";
            this.pathToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.pathToolStripMenuItem.Text = "Path";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // b_Surface
            // 
            this.b_Surface.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_Surface.Enabled = false;
            this.b_Surface.Location = new System.Drawing.Point(0, 174);
            this.b_Surface.Name = "b_Surface";
            this.b_Surface.Size = new System.Drawing.Size(704, 30);
            this.b_Surface.TabIndex = 7;
            this.b_Surface.Text = "Surface";
            this.b_Surface.UseVisualStyleBackColor = true;
            this.b_Surface.Click += new System.EventHandler(this.b_Surface_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 204);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(704, 267);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 471);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.b_Surface);
            this.Controls.Add(this.b_Clear);
            this.Controls.Add(this.b_FindAndDrawPath);
            this.Controls.Add(this.b_FindAndDrawNet);
            this.Controls.Add(this.b_DrawPoints);
            this.Controls.Add(this.b_Load);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Load;
        private System.Windows.Forms.Button b_DrawPoints;
        private System.Windows.Forms.Button b_FindAndDrawNet;
        private System.Windows.Forms.Button b_FindAndDrawPath;
        private System.Windows.Forms.Button b_Clear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadRegularNetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveGeneratedDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveRegularNetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regularNetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pathToolStripMenuItem;
        private System.Windows.Forms.Button b_Surface;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}