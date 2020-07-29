﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Belive
{
    public partial class MainForm : Form
    {
        private const string Rules =
            "Если ответ правильный, начисляется одно очко. При неправильном ответе очко отнимается.";
        private TrueFalse _db;
        private string _pathSave = string.Empty;
        private readonly string _path = "data.txt";
        private int _valueCountDb;
        private int _result;

        public MainForm()
        {
            InitializeComponent();
            LoadDefaultParameters();
        }

        private void LoadDefaultParameters()
        {
            Qlbl.Parent = ImageBoxQ;
            Qlbl.Dock = DockStyle.Fill;
            Albl.Parent = ImageBoxA;
            Albl.Dock = DockStyle.Fill;
            GamePanel.Visible = false;
            EditorPanel.Visible = false;
            MainGameLbl.Parent = GamePictureBox;
            ExitMainMenuBtn.Parent = GamePictureBox;
            ContinueBtn.Parent = GamePictureBox;
            TrueBtn.Parent = GamePictureBox;
            FalseBtn.Parent = GamePictureBox;
            ResultLbl.Parent = GamePictureBox;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SavePathDb(sfd.FileName);
                _db = new TrueFalse(sfd.FileName);
                _db.Add("testQ", "testA", true, string.Empty, string.Empty);
                _db.Save();

                NumQuestion.Minimum = 1;
                NumQuestion.Maximum = 1;
                NumQuestion.Value = 1;
            }
        }

        private void SavePathDb(string path)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.Write(path);
            sw.Dispose();
        }

        private void LoadPathDb(string path)
        {
            StreamReader sr = new StreamReader(path);
            _pathSave = sr.ReadToEnd();
            sr.Dispose();
        }

        private void NumQuestion_ValueChanged(object sender, EventArgs e)
        {
            if (IsDataBaseNoCreate()) return;
            Qlbl.Text = _db[(int)NumQuestion.Value - 1].TextQuestion;
            Albl.Text = _db[(int) NumQuestion.Value - 1].TextAnswer;
            TrueFalseCheck.Checked = _db[(int)NumQuestion.Value - 1].IsTrue;
            ImageBoxQ.ImageLocation = _db[(int) NumQuestion.Value - 1].PathImageQuestion;
            ImageBoxA.ImageLocation = _db[(int)NumQuestion.Value - 1].PathImageAnswer;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (IsDataBaseNoCreate()) return;
            _db.Add((_db.Count + 1).ToString(), string.Empty, true, string.Empty, string.Empty);
            NumQuestion.Maximum = _db.Count;
            NumQuestion.Value = _db.Count;
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (IsDataBaseNoCreate()) return;

            if (NumQuestion.Maximum == 1 || _db == null) return;
            _db.Remove((int)NumQuestion.Value);
            NumQuestion.Maximum--;
            if (NumQuestion.Value > 1)
                NumQuestion.Value = NumQuestion.Value;
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (_db != null) _db.Save();
            else MessageBox.Show(@"База данных не создана");
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LoadParam(ofd.FileName);
            }
        }

        private void LoadParam(string path)
        {
            try
            {
                _db = new TrueFalse(path);
                _db.Load();
                NumQuestion.Minimum = 1;
                NumQuestion.Maximum = _db.Count;
                NumQuestion.Value = 1;
            }
            catch
            {
                MessageBox.Show(@"Базаданных не загружена");
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (IsDataBaseNoCreate()) return;
            _db[(int)NumQuestion.Value - 1].TextQuestion = QuestionTextBox.Text;
            _db[(int)NumQuestion.Value - 1].IsTrue = TrueFalseCheck.Checked;
            Qlbl.Text = QuestionTextBox.Text;
        }

        private void AddImgBtn_Click(object sender, EventArgs e)
        {
            if (IsDataBaseNoCreate()) return;

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var path = ImageBoxQ.ImageLocation = ofd.FileName;
                ImageBoxQ.Image = Image.FromFile(path);
                _db[(int)NumQuestion.Value - 1].PathImageQuestion = path;
            }
        }

        private bool IsDataBaseNoCreate()
        {
            if (_db == null)
            {
                MessageBox.Show(@"Для корректной работы необходимо открыть сохраненную базу данных или создать новую.");
                return true;
            }

            return false;
        }

        private void ImgAnsBtn_Click(object sender, EventArgs e)
        {
            if (IsDataBaseNoCreate()) return;

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ImageBoxA.ImageLocation = ofd.FileName;
                _db[(int)NumQuestion.Value - 1].PathImageAnswer = ImageBoxA.ImageLocation;
            }
        }

        private void SaveBtnA_Click(object sender, EventArgs e)
        {
            if (IsDataBaseNoCreate()) return;
            _db[(int)NumQuestion.Value - 1].TextAnswer = QuestionTextBox.Text;
            _db[(int)NumQuestion.Value - 1].IsTrue = TrueFalseCheck.Checked;
            Albl.Text = QuestionTextBox.Text;
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            _valueCountDb = 0;
            _result = 0;
            MainGameLbl.Text = Rules;
            ResultLbl.Text = $@"Счет: {_result}";
            GamePictureBox.Image = null;
            GamePanel.Visible = true;
            MainMenuPanel.Visible = false;
            EditorPanel.Visible = false;
        }

        private void ExitMainMenuBtn_Click(object sender, EventArgs e)
        {
            GamePanel.Visible = false;
            MainMenuPanel.Visible = true;
        }

        private void MoveEditorBtn_Click(object sender, EventArgs e)
        {
            GamePanel.Visible = false;
            MainMenuPanel.Visible = false;
            EditorPanel.Visible = true;
        }

        private void ReturnMenuBtn_Click(object sender, EventArgs e)
        {
            GamePanel.Visible = false;
            MainMenuPanel.Visible = true;
            EditorPanel.Visible = false;
        }

        private void ExitBtnMain_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ContinueBtn_Click(object sender, EventArgs e)
        {
            LoadPathDb(_path);
            if (_pathSave != string.Empty && _pathSave != "")
            {
                LoadParam(_pathSave);
            }
            TrueBtn.Visible = true;
            FalseBtn.Visible = true;
            ContinueBtn.Visible = false;
            GamePictureBox.ImageLocation = _db[_valueCountDb].PathImageQuestion;
            MainGameLbl.Text = _db[_valueCountDb].TextQuestion;
        }

        private void TrueBtn_Click(object sender, EventArgs e)
        {
            GamePictureBox.ImageLocation = _db[_valueCountDb].PathImageAnswer;
            MainGameLbl.Text = _db[_valueCountDb].TextAnswer;
            if (!_db[_valueCountDb].IsTrue)
                _result--;
            else
            {
                _result++;
            }
            ResultLbl.Text = $@"Счет: {_result}";

            if (_valueCountDb < _db.Count - 1)
                _valueCountDb++;
            else
            {
                MessageBox.Show(@"Игра окончена");
            }
            TrueBtn.Visible = false;
            FalseBtn.Visible = false;
            ContinueBtn.Visible = true;
        }

        private void FalseBtn_Click(object sender, EventArgs e)
        {
            GamePictureBox.ImageLocation = _db[_valueCountDb].PathImageAnswer;
            MainGameLbl.Text = _db[_valueCountDb].TextAnswer;
            if (_db[_valueCountDb].IsTrue)
                _result--;
            else
            {
                _result++;
            }
            ResultLbl.Text = $@"Счет: {_result}";

            if (_valueCountDb < _db.Count - 1)
                _valueCountDb++;
            else
            {
                MessageBox.Show(@"Игра окончена");
                MainMenuPanel.Visible = true;
                GamePanel.Visible = false;
            }
            TrueBtn.Visible = false;
            FalseBtn.Visible = false;
            ContinueBtn.Visible = true;
        }

        private void Qlbl_Click(object sender, EventArgs e)
        {
            QuestionTextBox.Text = Qlbl.Text;
        }

        private void Albl_Click(object sender, EventArgs e)
        {
            QuestionTextBox.Text = Albl.Text;
        }

        private void TrueFalseCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (IsDataBaseNoCreate()) return;

            _db[(int) NumQuestion.Value - 1].IsTrue = TrueFalseCheck.CheckState == CheckState.Checked;
        }
    }
}
