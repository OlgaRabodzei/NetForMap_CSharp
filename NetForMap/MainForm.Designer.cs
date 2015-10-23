namespace NetForMap
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьРезультатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.соханитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алгоритмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сгенерироватьТестовуюПоверхностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сгенерироватьТестовыеДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.вычислитьРегулярнуюСеткуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отобразитьТочкиНаПлоскостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.плоскостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестоваяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.построеннаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.b_Start = new System.Windows.Forms.Button();
            this.b_Exit = new System.Windows.Forms.Button();
            this.b_Save = new System.Windows.Forms.Button();
            this.b_Draw = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.алгоритмToolStripMenuItem,
            this.плоскостиToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(649, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьДанныеToolStripMenuItem,
            this.toolStripMenuItem1,
            this.сохранитьДанныеToolStripMenuItem,
            this.сохранитьРезультатToolStripMenuItem,
            this.соханитьВсеToolStripMenuItem,
            this.toolStripMenuItem2,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // загрузитьДанныеToolStripMenuItem
            // 
            this.загрузитьДанныеToolStripMenuItem.Name = "загрузитьДанныеToolStripMenuItem";
            this.загрузитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.загрузитьДанныеToolStripMenuItem.Text = "Загрузить данные";
            this.загрузитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.загрузитьДанныеToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(185, 6);
            // 
            // сохранитьДанныеToolStripMenuItem
            // 
            this.сохранитьДанныеToolStripMenuItem.Name = "сохранитьДанныеToolStripMenuItem";
            this.сохранитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.сохранитьДанныеToolStripMenuItem.Text = "Сохранить данные";
            this.сохранитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.сохранитьДанныеToolStripMenuItem_Click);
            // 
            // сохранитьРезультатToolStripMenuItem
            // 
            this.сохранитьРезультатToolStripMenuItem.Name = "сохранитьРезультатToolStripMenuItem";
            this.сохранитьРезультатToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.сохранитьРезультатToolStripMenuItem.Text = "Сохранить результат";
            this.сохранитьРезультатToolStripMenuItem.Click += new System.EventHandler(this.сохранитьРезультатToolStripMenuItem_Click);
            // 
            // соханитьВсеToolStripMenuItem
            // 
            this.соханитьВсеToolStripMenuItem.Name = "соханитьВсеToolStripMenuItem";
            this.соханитьВсеToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.соханитьВсеToolStripMenuItem.Text = "Соханить все";
            this.соханитьВсеToolStripMenuItem.Click += new System.EventHandler(this.соханитьВсеToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(185, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // алгоритмToolStripMenuItem
            // 
            this.алгоритмToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сгенерироватьТестовуюПоверхностьToolStripMenuItem,
            this.сгенерироватьТестовыеДанныеToolStripMenuItem,
            this.toolStripMenuItem3,
            this.вычислитьРегулярнуюСеткуToolStripMenuItem,
            this.отобразитьТочкиНаПлоскостиToolStripMenuItem});
            this.алгоритмToolStripMenuItem.Name = "алгоритмToolStripMenuItem";
            this.алгоритмToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.алгоритмToolStripMenuItem.Text = "Алгоритм";
            // 
            // сгенерироватьТестовуюПоверхностьToolStripMenuItem
            // 
            this.сгенерироватьТестовуюПоверхностьToolStripMenuItem.Name = "сгенерироватьТестовуюПоверхностьToolStripMenuItem";
            this.сгенерироватьТестовуюПоверхностьToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.сгенерироватьТестовуюПоверхностьToolStripMenuItem.Text = "Сгенерировать тестовую поверхность";
            this.сгенерироватьТестовуюПоверхностьToolStripMenuItem.Click += new System.EventHandler(this.сгенерироватьТестовуюПоверхностьToolStripMenuItem_Click);
            // 
            // сгенерироватьТестовыеДанныеToolStripMenuItem
            // 
            this.сгенерироватьТестовыеДанныеToolStripMenuItem.Name = "сгенерироватьТестовыеДанныеToolStripMenuItem";
            this.сгенерироватьТестовыеДанныеToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.сгенерироватьТестовыеДанныеToolStripMenuItem.Text = "Сгенерировать тестовые данные";
            this.сгенерироватьТестовыеДанныеToolStripMenuItem.Click += new System.EventHandler(this.сгенерироватьТестовыеДанныеToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(280, 6);
            // 
            // вычислитьРегулярнуюСеткуToolStripMenuItem
            // 
            this.вычислитьРегулярнуюСеткуToolStripMenuItem.Name = "вычислитьРегулярнуюСеткуToolStripMenuItem";
            this.вычислитьРегулярнуюСеткуToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.вычислитьРегулярнуюСеткуToolStripMenuItem.Text = "Вычислить регулярную сетку";
            this.вычислитьРегулярнуюСеткуToolStripMenuItem.Click += new System.EventHandler(this.вычислитьРегулярнуюСеткуToolStripMenuItem_Click);
            // 
            // отобразитьТочкиНаПлоскостиToolStripMenuItem
            // 
            this.отобразитьТочкиНаПлоскостиToolStripMenuItem.Name = "отобразитьТочкиНаПлоскостиToolStripMenuItem";
            this.отобразитьТочкиНаПлоскостиToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.отобразитьТочкиНаПлоскостиToolStripMenuItem.Text = "Отобразить точки на плоскости";
            this.отобразитьТочкиНаПлоскостиToolStripMenuItem.Click += new System.EventHandler(this.отобразитьТочкиНаПлоскостиToolStripMenuItem_Click);
            // 
            // плоскостиToolStripMenuItem
            // 
            this.плоскостиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тестоваяToolStripMenuItem,
            this.построеннаяToolStripMenuItem});
            this.плоскостиToolStripMenuItem.Name = "плоскостиToolStripMenuItem";
            this.плоскостиToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.плоскостиToolStripMenuItem.Text = "Поверхности";
            // 
            // тестоваяToolStripMenuItem
            // 
            this.тестоваяToolStripMenuItem.Name = "тестоваяToolStripMenuItem";
            this.тестоваяToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.тестоваяToolStripMenuItem.Text = "Тестовая";
            this.тестоваяToolStripMenuItem.Click += new System.EventHandler(this.тестоваяToolStripMenuItem_Click);
            // 
            // построеннаяToolStripMenuItem
            // 
            this.построеннаяToolStripMenuItem.Name = "построеннаяToolStripMenuItem";
            this.построеннаяToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.построеннаяToolStripMenuItem.Text = "Построенная";
            this.построеннаяToolStripMenuItem.Click += new System.EventHandler(this.построеннаяToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Exel files|*.xlsx";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Exel files|*.xlsx";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // b_Start
            // 
            this.b_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Start.Location = new System.Drawing.Point(537, 49);
            this.b_Start.Name = "b_Start";
            this.b_Start.Size = new System.Drawing.Size(75, 19);
            this.b_Start.TabIndex = 1;
            this.b_Start.Text = "Start";
            this.b_Start.UseVisualStyleBackColor = true;
            this.b_Start.Click += new System.EventHandler(this.вычислитьРегулярнуюСеткуToolStripMenuItem_Click);
            // 
            // b_Exit
            // 
            this.b_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Exit.Location = new System.Drawing.Point(537, 163);
            this.b_Exit.Name = "b_Exit";
            this.b_Exit.Size = new System.Drawing.Size(75, 19);
            this.b_Exit.TabIndex = 2;
            this.b_Exit.Text = "Exit";
            this.b_Exit.UseVisualStyleBackColor = true;
            this.b_Exit.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // b_Save
            // 
            this.b_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Save.Location = new System.Drawing.Point(537, 85);
            this.b_Save.Name = "b_Save";
            this.b_Save.Size = new System.Drawing.Size(75, 19);
            this.b_Save.TabIndex = 3;
            this.b_Save.Text = "Save all";
            this.b_Save.UseVisualStyleBackColor = true;
            this.b_Save.Click += new System.EventHandler(this.соханитьВсеToolStripMenuItem_Click);
            // 
            // b_Draw
            // 
            this.b_Draw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Draw.Location = new System.Drawing.Point(537, 122);
            this.b_Draw.Name = "b_Draw";
            this.b_Draw.Size = new System.Drawing.Size(75, 23);
            this.b_Draw.TabIndex = 5;
            this.b_Draw.Text = "Draw";
            this.b_Draw.UseVisualStyleBackColor = true;
            this.b_Draw.Click += new System.EventHandler(this.отобразитьТочкиНаПлоскостиToolStripMenuItem_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(0, 27);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(493, 436);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Весовая функция:";
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(527, 224);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 20);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1/|u|";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Image = ((System.Drawing.Image)(resources.GetObject("radioButton2.Image")));
            this.radioButton2.Location = new System.Drawing.Point(527, 249);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 40);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton3.AutoSize = true;
            this.radioButton3.Image = ((System.Drawing.Image)(resources.GetObject("radioButton3.Image")));
            this.radioButton3.Location = new System.Drawing.Point(527, 292);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(90, 34);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(514, 361);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(118, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Параметр локальности";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 463);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.b_Draw);
            this.Controls.Add(this.b_Save);
            this.Controls.Add(this.b_Exit);
            this.Controls.Add(this.b_Start);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Метод весовой аппроксимации";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьРезультатToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button b_Start;
        private System.Windows.Forms.Button b_Exit;
        private System.Windows.Forms.Button b_Save;
        private System.Windows.Forms.Button b_Draw;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ToolStripMenuItem алгоритмToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вычислитьРегулярнуюСеткуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отобразитьТочкиНаПлоскостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem плоскостиToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem сгенерироватьТестовуюПоверхностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem сохранитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem соханитьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестоваяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem построеннаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сгенерироватьТестовыеДанныеToolStripMenuItem;
    }
}

