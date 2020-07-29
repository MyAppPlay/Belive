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
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.SaveBtnQ = new System.Windows.Forms.Button();
            this.NumQuestion = new System.Windows.Forms.NumericUpDown();
            this.AddImgBtn = new System.Windows.Forms.Button();
            this.ImgAnsBtn = new System.Windows.Forms.Button();
            this.SwithMode = new System.Windows.Forms.Button();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.EditorPanel = new System.Windows.Forms.Panel();
            this.ReturnMenuBtn = new System.Windows.Forms.Button();
            this.Qlbl = new System.Windows.Forms.Label();
            this.ImageBoxQ = new System.Windows.Forms.PictureBox();
            this.Albl = new System.Windows.Forms.Label();
            this.ImageBoxA = new System.Windows.Forms.PictureBox();
            this.SaveBtnA = new System.Windows.Forms.Button();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.ExitBtnMain = new System.Windows.Forms.Button();
            this.MoveEditorBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.MainGameLbl = new System.Windows.Forms.Label();
            this.ExitMainMenuBtn = new System.Windows.Forms.Button();
            this.ContinueBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FalseBtn = new System.Windows.Forms.Button();
            this.TrueBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GamePictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuestion)).BeginInit();
            this.EditorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBoxQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBoxA)).BeginInit();
            this.MainMenuPanel.SuspendLayout();
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TrueFalseCheck
            // 
            this.TrueFalseCheck.AutoSize = true;
            this.TrueFalseCheck.Location = new System.Drawing.Point(706, 329);
            this.TrueFalseCheck.Name = "TrueFalseCheck";
            this.TrueFalseCheck.Size = new System.Drawing.Size(64, 17);
            this.TrueFalseCheck.TabIndex = 0;
            this.TrueFalseCheck.Text = "Правда";
            this.TrueFalseCheck.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
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
            this.NewFile.Size = new System.Drawing.Size(156, 22);
            this.NewFile.Text = "Создать новый";
            this.NewFile.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(156, 22);
            this.OpenFile.Text = "Открыть";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(156, 22);
            this.SaveFile.Text = "Сохранить";
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(156, 22);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(615, 297);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(69, 23);
            this.AddBtn.TabIndex = 11;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelBtn.Location = new System.Drawing.Point(615, 352);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(69, 23);
            this.DelBtn.TabIndex = 9;
            this.DelBtn.Text = "Удалить";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // SaveBtnQ
            // 
            this.SaveBtnQ.Location = new System.Drawing.Point(486, 309);
            this.SaveBtnQ.Name = "SaveBtnQ";
            this.SaveBtnQ.Size = new System.Drawing.Size(110, 23);
            this.SaveBtnQ.TabIndex = 4;
            this.SaveBtnQ.Text = "Сохранить вопрос";
            this.SaveBtnQ.UseVisualStyleBackColor = true;
            this.SaveBtnQ.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // NumQuestion
            // 
            this.NumQuestion.Location = new System.Drawing.Point(615, 326);
            this.NumQuestion.Name = "NumQuestion";
            this.NumQuestion.Size = new System.Drawing.Size(69, 20);
            this.NumQuestion.TabIndex = 6;
            this.NumQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumQuestion.ValueChanged += new System.EventHandler(this.NumQuestion_ValueChanged);
            // 
            // AddImgBtn
            // 
            this.AddImgBtn.Location = new System.Drawing.Point(53, 52);
            this.AddImgBtn.Name = "AddImgBtn";
            this.AddImgBtn.Size = new System.Drawing.Size(112, 23);
            this.AddImgBtn.TabIndex = 8;
            this.AddImgBtn.Text = "Картинка вопроса";
            this.AddImgBtn.UseVisualStyleBackColor = true;
            this.AddImgBtn.Click += new System.EventHandler(this.AddImgBtn_Click);
            // 
            // ImgAnsBtn
            // 
            this.ImgAnsBtn.Location = new System.Drawing.Point(615, 52);
            this.ImgAnsBtn.Name = "ImgAnsBtn";
            this.ImgAnsBtn.Size = new System.Drawing.Size(112, 23);
            this.ImgAnsBtn.TabIndex = 10;
            this.ImgAnsBtn.Text = "Картинка ответа";
            this.ImgAnsBtn.UseVisualStyleBackColor = true;
            this.ImgAnsBtn.Click += new System.EventHandler(this.ImgAnsBtn_Click);
            // 
            // SwithMode
            // 
            this.SwithMode.Location = new System.Drawing.Point(303, 320);
            this.SwithMode.Name = "SwithMode";
            this.SwithMode.Size = new System.Drawing.Size(142, 41);
            this.SwithMode.TabIndex = 18;
            this.SwithMode.Text = "Переключатель";
            this.SwithMode.UseVisualStyleBackColor = true;
            this.SwithMode.Click += new System.EventHandler(this.SwithMode_Click);
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.QuestionTextBox.Location = new System.Drawing.Point(12, 297);
            this.QuestionTextBox.Multiline = true;
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(455, 78);
            this.QuestionTextBox.TabIndex = 19;
            // 
            // EditorPanel
            // 
            this.EditorPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditorPanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.EditorPanel.BackgroundImage = global::Belive.Properties.Resources.IconMain;
            this.EditorPanel.Controls.Add(this.ReturnMenuBtn);
            this.EditorPanel.Controls.Add(this.Qlbl);
            this.EditorPanel.Controls.Add(this.ImgAnsBtn);
            this.EditorPanel.Controls.Add(this.AddImgBtn);
            this.EditorPanel.Controls.Add(this.ImageBoxQ);
            this.EditorPanel.Controls.Add(this.Albl);
            this.EditorPanel.Controls.Add(this.ImageBoxA);
            this.EditorPanel.Controls.Add(this.menuStrip1);
            this.EditorPanel.Controls.Add(this.SaveBtnA);
            this.EditorPanel.Controls.Add(this.AddBtn);
            this.EditorPanel.Controls.Add(this.QuestionTextBox);
            this.EditorPanel.Controls.Add(this.DelBtn);
            this.EditorPanel.Controls.Add(this.SaveBtnQ);
            this.EditorPanel.Controls.Add(this.TrueFalseCheck);
            this.EditorPanel.Controls.Add(this.NumQuestion);
            this.EditorPanel.Controls.Add(this.SwithMode);
            this.EditorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorPanel.Location = new System.Drawing.Point(0, 0);
            this.EditorPanel.Name = "EditorPanel";
            this.EditorPanel.Size = new System.Drawing.Size(784, 411);
            this.EditorPanel.TabIndex = 20;
            this.EditorPanel.Visible = false;
            // 
            // ReturnMenuBtn
            // 
            this.ReturnMenuBtn.Location = new System.Drawing.Point(328, 27);
            this.ReturnMenuBtn.Name = "ReturnMenuBtn";
            this.ReturnMenuBtn.Size = new System.Drawing.Size(110, 23);
            this.ReturnMenuBtn.TabIndex = 27;
            this.ReturnMenuBtn.Text = "Выход в меню";
            this.ReturnMenuBtn.UseVisualStyleBackColor = true;
            this.ReturnMenuBtn.Click += new System.EventHandler(this.ReturnMenuBtn_Click);
            // 
            // Qlbl
            // 
            this.Qlbl.AutoEllipsis = true;
            this.Qlbl.BackColor = System.Drawing.Color.Transparent;
            this.Qlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Qlbl.Location = new System.Drawing.Point(93, 147);
            this.Qlbl.Name = "Qlbl";
            this.Qlbl.Size = new System.Drawing.Size(209, 31);
            this.Qlbl.TabIndex = 25;
            this.Qlbl.Text = "Текст вопроса";
            this.Qlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImageBoxQ
            // 
            this.ImageBoxQ.BackgroundImage = global::Belive.Properties.Resources.IconMain;
            this.ImageBoxQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImageBoxQ.Location = new System.Drawing.Point(12, 52);
            this.ImageBoxQ.Name = "ImageBoxQ";
            this.ImageBoxQ.Size = new System.Drawing.Size(370, 239);
            this.ImageBoxQ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBoxQ.TabIndex = 23;
            this.ImageBoxQ.TabStop = false;
            // 
            // Albl
            // 
            this.Albl.BackColor = System.Drawing.Color.Transparent;
            this.Albl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Albl.Location = new System.Drawing.Point(486, 147);
            this.Albl.Name = "Albl";
            this.Albl.Size = new System.Drawing.Size(188, 31);
            this.Albl.TabIndex = 26;
            this.Albl.Text = "Текст ответа";
            this.Albl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImageBoxA
            // 
            this.ImageBoxA.BackgroundImage = global::Belive.Properties.Resources.IconMain;
            this.ImageBoxA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImageBoxA.Location = new System.Drawing.Point(400, 52);
            this.ImageBoxA.Name = "ImageBoxA";
            this.ImageBoxA.Size = new System.Drawing.Size(370, 239);
            this.ImageBoxA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBoxA.TabIndex = 24;
            this.ImageBoxA.TabStop = false;
            // 
            // SaveBtnA
            // 
            this.SaveBtnA.Location = new System.Drawing.Point(486, 338);
            this.SaveBtnA.Name = "SaveBtnA";
            this.SaveBtnA.Size = new System.Drawing.Size(110, 23);
            this.SaveBtnA.TabIndex = 22;
            this.SaveBtnA.Text = "Сохранить ответ";
            this.SaveBtnA.UseVisualStyleBackColor = true;
            this.SaveBtnA.Click += new System.EventHandler(this.SaveBtnA_Click);
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.BackColor = System.Drawing.Color.SlateBlue;
            this.MainMenuPanel.BackgroundImage = global::Belive.Properties.Resources.IconMain;
            this.MainMenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainMenuPanel.Controls.Add(this.ExitBtnMain);
            this.MainMenuPanel.Controls.Add(this.MoveEditorBtn);
            this.MainMenuPanel.Controls.Add(this.PlayBtn);
            this.MainMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(784, 411);
            this.MainMenuPanel.TabIndex = 22;
            // 
            // ExitBtnMain
            // 
            this.ExitBtnMain.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtnMain.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBtnMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitBtnMain.Location = new System.Drawing.Point(303, 307);
            this.ExitBtnMain.Name = "ExitBtnMain";
            this.ExitBtnMain.Size = new System.Drawing.Size(223, 47);
            this.ExitBtnMain.TabIndex = 2;
            this.ExitBtnMain.Text = "ВЫХОД";
            this.ExitBtnMain.UseVisualStyleBackColor = false;
            this.ExitBtnMain.Click += new System.EventHandler(this.ExitBtnMain_Click);
            // 
            // MoveEditorBtn
            // 
            this.MoveEditorBtn.BackColor = System.Drawing.Color.Transparent;
            this.MoveEditorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveEditorBtn.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveEditorBtn.Location = new System.Drawing.Point(303, 201);
            this.MoveEditorBtn.Name = "MoveEditorBtn";
            this.MoveEditorBtn.Size = new System.Drawing.Size(223, 57);
            this.MoveEditorBtn.TabIndex = 1;
            this.MoveEditorBtn.Text = "РЕДАКТОР";
            this.MoveEditorBtn.UseVisualStyleBackColor = false;
            this.MoveEditorBtn.Click += new System.EventHandler(this.MoveEditorBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PlayBtn.BackColor = System.Drawing.Color.Transparent;
            this.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayBtn.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayBtn.ForeColor = System.Drawing.Color.Lime;
            this.PlayBtn.Location = new System.Drawing.Point(303, 98);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(223, 49);
            this.PlayBtn.TabIndex = 0;
            this.PlayBtn.Text = "ИГРАТЬ";
            this.PlayBtn.UseVisualStyleBackColor = false;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // GamePanel
            // 
            this.GamePanel.Controls.Add(this.MainGameLbl);
            this.GamePanel.Controls.Add(this.ExitMainMenuBtn);
            this.GamePanel.Controls.Add(this.ContinueBtn);
            this.GamePanel.Controls.Add(this.label2);
            this.GamePanel.Controls.Add(this.FalseBtn);
            this.GamePanel.Controls.Add(this.TrueBtn);
            this.GamePanel.Controls.Add(this.label1);
            this.GamePanel.Controls.Add(this.GamePictureBox);
            this.GamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamePanel.Location = new System.Drawing.Point(0, 0);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(784, 411);
            this.GamePanel.TabIndex = 3;
            this.GamePanel.Visible = false;
            // 
            // MainGameLbl
            // 
            this.MainGameLbl.AutoSize = true;
            this.MainGameLbl.Location = new System.Drawing.Point(264, 164);
            this.MainGameLbl.Name = "MainGameLbl";
            this.MainGameLbl.Size = new System.Drawing.Size(35, 13);
            this.MainGameLbl.TabIndex = 7;
            this.MainGameLbl.Text = "label3";
            // 
            // ExitMainMenuBtn
            // 
            this.ExitMainMenuBtn.Location = new System.Drawing.Point(12, 13);
            this.ExitMainMenuBtn.Name = "ExitMainMenuBtn";
            this.ExitMainMenuBtn.Size = new System.Drawing.Size(153, 33);
            this.ExitMainMenuBtn.TabIndex = 6;
            this.ExitMainMenuBtn.Text = "Выход в меню";
            this.ExitMainMenuBtn.UseVisualStyleBackColor = true;
            this.ExitMainMenuBtn.Click += new System.EventHandler(this.ExitMainMenuBtn_Click);
            // 
            // ContinueBtn
            // 
            this.ContinueBtn.Location = new System.Drawing.Point(615, 13);
            this.ContinueBtn.Name = "ContinueBtn";
            this.ContinueBtn.Size = new System.Drawing.Size(157, 33);
            this.ContinueBtn.TabIndex = 5;
            this.ContinueBtn.Text = " Продолжить";
            this.ContinueBtn.UseVisualStyleBackColor = true;
            this.ContinueBtn.Click += new System.EventHandler(this.ContinueBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Счет";
            // 
            // FalseBtn
            // 
            this.FalseBtn.AutoEllipsis = true;
            this.FalseBtn.Location = new System.Drawing.Point(690, 309);
            this.FalseBtn.Name = "FalseBtn";
            this.FalseBtn.Size = new System.Drawing.Size(82, 88);
            this.FalseBtn.TabIndex = 3;
            this.FalseBtn.Text = "Не верю";
            this.FalseBtn.UseVisualStyleBackColor = true;
            this.FalseBtn.Visible = false;
            this.FalseBtn.Click += new System.EventHandler(this.FalseBtn_Click);
            // 
            // TrueBtn
            // 
            this.TrueBtn.AutoEllipsis = true;
            this.TrueBtn.Location = new System.Drawing.Point(12, 307);
            this.TrueBtn.Name = "TrueBtn";
            this.TrueBtn.Size = new System.Drawing.Size(85, 90);
            this.TrueBtn.TabIndex = 2;
            this.TrueBtn.Text = "Верю";
            this.TrueBtn.UseVisualStyleBackColor = true;
            this.TrueBtn.Visible = false;
            this.TrueBtn.Click += new System.EventHandler(this.TrueBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Правила игры";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GamePictureBox
            // 
            this.GamePictureBox.BackgroundImage = global::Belive.Properties.Resources.IconMain;
            this.GamePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GamePictureBox.Location = new System.Drawing.Point(119, 52);
            this.GamePictureBox.Name = "GamePictureBox";
            this.GamePictureBox.Size = new System.Drawing.Size(555, 356);
            this.GamePictureBox.TabIndex = 0;
            this.GamePictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Belive.Properties.Resources.IconMain;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.MainMenuPanel);
            this.Controls.Add(this.EditorPanel);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Верю, не верю.";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuestion)).EndInit();
            this.EditorPanel.ResumeLayout(false);
            this.EditorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBoxQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBoxA)).EndInit();
            this.MainMenuPanel.ResumeLayout(false);
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamePictureBox)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button SaveBtnQ;
        private System.Windows.Forms.NumericUpDown NumQuestion;
        private System.Windows.Forms.Button AddImgBtn;
        private System.Windows.Forms.Button ImgAnsBtn;
        private System.Windows.Forms.Button SwithMode;
        private System.Windows.Forms.TextBox QuestionTextBox;
        private System.Windows.Forms.Panel EditorPanel;
        private System.Windows.Forms.Button SaveBtnA;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Button ExitBtnMain;
        private System.Windows.Forms.Button MoveEditorBtn;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.PictureBox ImageBoxA;
        private System.Windows.Forms.PictureBox ImageBoxQ;
        private System.Windows.Forms.Label Albl;
        private System.Windows.Forms.Label Qlbl;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Button ExitMainMenuBtn;
        private System.Windows.Forms.Button ContinueBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FalseBtn;
        private System.Windows.Forms.Button TrueBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox GamePictureBox;
        private System.Windows.Forms.Button ReturnMenuBtn;
        private System.Windows.Forms.Label MainGameLbl;
    }
}

