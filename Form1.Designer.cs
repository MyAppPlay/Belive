namespace Belive
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TrueFalseCheck = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.NumQuestion = new System.Windows.Forms.NumericUpDown();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.AddImgBtn = new System.Windows.Forms.Button();
            this.ImgAnsBtn = new System.Windows.Forms.Button();
            this.QuestionLbl = new System.Windows.Forms.Label();
            this.TrueBtn = new System.Windows.Forms.Button();
            this.FalseBtn = new System.Windows.Forms.Button();
            this.CounterLbl = new System.Windows.Forms.Label();
            this.TrueCoutLbl = new System.Windows.Forms.Label();
            this.FalseCountLbl = new System.Windows.Forms.Label();
            this.SwithMode = new System.Windows.Forms.Button();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TrueFalseCheck
            // 
            this.TrueFalseCheck.AutoSize = true;
            this.TrueFalseCheck.Location = new System.Drawing.Point(691, 409);
            this.TrueFalseCheck.Name = "TrueFalseCheck";
            this.TrueFalseCheck.Size = new System.Drawing.Size(64, 17);
            this.TrueFalseCheck.TabIndex = 0;
            this.TrueFalseCheck.Text = "Правда";
            this.TrueFalseCheck.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFile,
            this.OpenFile,
            this.SaveFile,
            this.toolStripSeparator1,
            this.Exit});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(48, 20);
            this.FileMenu.Text = "Файл";
            // 
            // NewFile
            // 
            this.NewFile.Name = "NewFile";
            this.NewFile.Size = new System.Drawing.Size(180, 22);
            this.NewFile.Text = "Создать новый";
            this.NewFile.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(180, 22);
            this.OpenFile.Text = "Открыть";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(180, 22);
            this.SaveFile.Text = "Сохранить";
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(180, 22);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(12, 409);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 11;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(361, 406);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(75, 23);
            this.DelBtn.TabIndex = 9;
            this.DelBtn.Text = "Удалить";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(463, 405);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // NumQuestion
            // 
            this.NumQuestion.Location = new System.Drawing.Point(613, 406);
            this.NumQuestion.Name = "NumQuestion";
            this.NumQuestion.Size = new System.Drawing.Size(61, 20);
            this.NumQuestion.TabIndex = 6;
            this.NumQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumQuestion.ValueChanged += new System.EventHandler(this.NumQuestion_ValueChanged);
            // 
            // ImageBox
            // 
            this.ImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageBox.Image = global::Belive.Properties.Resources.Q1;
            this.ImageBox.Location = new System.Drawing.Point(0, 0);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(800, 450);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBox.TabIndex = 7;
            this.ImageBox.TabStop = false;
            // 
            // AddImgBtn
            // 
            this.AddImgBtn.Location = new System.Drawing.Point(129, 393);
            this.AddImgBtn.Name = "AddImgBtn";
            this.AddImgBtn.Size = new System.Drawing.Size(112, 23);
            this.AddImgBtn.TabIndex = 8;
            this.AddImgBtn.Text = "Картинка вопроса";
            this.AddImgBtn.UseVisualStyleBackColor = true;
            this.AddImgBtn.Click += new System.EventHandler(this.AddImgBtn_Click);
            // 
            // ImgAnsBtn
            // 
            this.ImgAnsBtn.Location = new System.Drawing.Point(129, 422);
            this.ImgAnsBtn.Name = "ImgAnsBtn";
            this.ImgAnsBtn.Size = new System.Drawing.Size(112, 23);
            this.ImgAnsBtn.TabIndex = 10;
            this.ImgAnsBtn.Text = "Картинка ответа";
            this.ImgAnsBtn.UseVisualStyleBackColor = true;
            // 
            // QuestionLbl
            // 
            this.QuestionLbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.QuestionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionLbl.BackColor = System.Drawing.Color.Transparent;
            this.QuestionLbl.Font = new System.Drawing.Font("Palatino Linotype", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionLbl.ForeColor = System.Drawing.Color.Red;
            this.QuestionLbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.QuestionLbl.Location = new System.Drawing.Point(13, 107);
            this.QuestionLbl.Name = "QuestionLbl";
            this.QuestionLbl.Size = new System.Drawing.Size(742, 185);
            this.QuestionLbl.TabIndex = 12;
            this.QuestionLbl.Text = "Вопрос";
            this.QuestionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.QuestionLbl.UseMnemonic = false;
            // 
            // TrueBtn
            // 
            this.TrueBtn.BackColor = System.Drawing.Color.Transparent;
            this.TrueBtn.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrueBtn.ForeColor = System.Drawing.Color.Green;
            this.TrueBtn.Location = new System.Drawing.Point(254, 325);
            this.TrueBtn.Name = "TrueBtn";
            this.TrueBtn.Size = new System.Drawing.Size(139, 42);
            this.TrueBtn.TabIndex = 13;
            this.TrueBtn.Text = "Верю";
            this.TrueBtn.UseVisualStyleBackColor = false;
            // 
            // FalseBtn
            // 
            this.FalseBtn.BackColor = System.Drawing.Color.Transparent;
            this.FalseBtn.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FalseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FalseBtn.Location = new System.Drawing.Point(399, 325);
            this.FalseBtn.Name = "FalseBtn";
            this.FalseBtn.Size = new System.Drawing.Size(139, 42);
            this.FalseBtn.TabIndex = 14;
            this.FalseBtn.Text = "Не верю";
            this.FalseBtn.UseVisualStyleBackColor = false;
            // 
            // CounterLbl
            // 
            this.CounterLbl.AutoSize = true;
            this.CounterLbl.BackColor = System.Drawing.Color.Transparent;
            this.CounterLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CounterLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CounterLbl.Location = new System.Drawing.Point(717, 34);
            this.CounterLbl.Name = "CounterLbl";
            this.CounterLbl.Size = new System.Drawing.Size(63, 24);
            this.CounterLbl.TabIndex = 15;
            this.CounterLbl.Text = "СЧЕТ";
            // 
            // TrueCoutLbl
            // 
            this.TrueCoutLbl.AutoSize = true;
            this.TrueCoutLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrueCoutLbl.ForeColor = System.Drawing.Color.Green;
            this.TrueCoutLbl.Location = new System.Drawing.Point(723, 69);
            this.TrueCoutLbl.Name = "TrueCoutLbl";
            this.TrueCoutLbl.Size = new System.Drawing.Size(21, 24);
            this.TrueCoutLbl.TabIndex = 16;
            this.TrueCoutLbl.Text = "0";
            // 
            // FalseCountLbl
            // 
            this.FalseCountLbl.AutoSize = true;
            this.FalseCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FalseCountLbl.ForeColor = System.Drawing.Color.Red;
            this.FalseCountLbl.Location = new System.Drawing.Point(759, 69);
            this.FalseCountLbl.Name = "FalseCountLbl";
            this.FalseCountLbl.Size = new System.Drawing.Size(21, 24);
            this.FalseCountLbl.TabIndex = 17;
            this.FalseCountLbl.Text = "0";
            // 
            // SwithMode
            // 
            this.SwithMode.Location = new System.Drawing.Point(613, 325);
            this.SwithMode.Name = "SwithMode";
            this.SwithMode.Size = new System.Drawing.Size(142, 41);
            this.SwithMode.TabIndex = 18;
            this.SwithMode.Text = "Переключатель";
            this.SwithMode.UseVisualStyleBackColor = true;
            this.SwithMode.Click += new System.EventHandler(this.SwithMode_Click);
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Location = new System.Drawing.Point(13, 325);
            this.QuestionTextBox.Multiline = true;
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(228, 62);
            this.QuestionTextBox.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuestionTextBox);
            this.Controls.Add(this.SwithMode);
            this.Controls.Add(this.FalseCountLbl);
            this.Controls.Add(this.TrueCoutLbl);
            this.Controls.Add(this.CounterLbl);
            this.Controls.Add(this.FalseBtn);
            this.Controls.Add(this.TrueBtn);
            this.Controls.Add(this.QuestionLbl);
            this.Controls.Add(this.TrueFalseCheck);
            this.Controls.Add(this.NumQuestion);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ImgAnsBtn);
            this.Controls.Add(this.AddImgBtn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ImageBox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Верю, не верю.";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox TrueFalseCheck;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem NewFile;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripMenuItem SaveFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.NumericUpDown NumQuestion;
        public System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Button AddImgBtn;
        private System.Windows.Forms.Button ImgAnsBtn;
        private System.Windows.Forms.Label QuestionLbl;
        private System.Windows.Forms.Button TrueBtn;
        private System.Windows.Forms.Button FalseBtn;
        private System.Windows.Forms.Label CounterLbl;
        private System.Windows.Forms.Label TrueCoutLbl;
        private System.Windows.Forms.Label FalseCountLbl;
        private System.Windows.Forms.Button SwithMode;
        private System.Windows.Forms.TextBox QuestionTextBox;
    }
}

