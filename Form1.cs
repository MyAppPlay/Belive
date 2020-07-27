using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Belive
{
    public partial class MainForm : Form
    {
        private TrueFalse _db;
        private string _pathSave = string.Empty;
        private bool _isGameMode;
        private string _path = "data.txt";
        private bool _isCorrectValue = true;
        private int _trueValue = 0;
        private int _falseValue = 0;

        public MainForm()
        {
            InitializeComponent();
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
            if (_db != null)
            {
                QuestionLbl.Text = _db[(int)NumQuestion.Value - 1].TextQuestion;
                TrueFalseCheck.Checked = _db[(int)NumQuestion.Value - 1].IsTrue;
                ImageBox.ImageLocation = _db[(int)NumQuestion.Value - 1].PathImageQuestion;
                UIPanel.Parent = ImageBox;
                _isCorrectValue = true;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (_db == null)
            {
                MessageBox.Show(@"Создайте новую базу данных", @"Сообщение");
                return;
            }
            _db.Add((_db.Count + 1).ToString(), string.Empty, true, string.Empty, string.Empty);
            NumQuestion.Maximum = _db.Count;
            NumQuestion.Value = _db.Count;
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
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
            LoadPathDb(_path);
            if (_pathSave != string.Empty && _pathSave != "")
            {
                LoadParam(_pathSave);
                return;
            }
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LoadParam(ofd.FileName);
            }
        }

        private void LoadParam(string path)
        {
            _db = new TrueFalse(path);
            _db.Load();
            NumQuestion.Minimum = 1;
            NumQuestion.Maximum = _db.Count;
            NumQuestion.Value = 1;
            QuestionLbl.Parent = ImageBox;
            QuestionLbl.BackColor = Color.Transparent;
            TrueCoutLbl.Text = _trueValue.ToString();
            TrueCoutLbl.Text = _falseValue.ToString();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (_db == null) return;
            _db[(int)NumQuestion.Value - 1].TextQuestion = QuestionTextBox.Text;
            _db[(int)NumQuestion.Value - 1].IsTrue = TrueFalseCheck.Checked;
        }

        private void AddImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ImageBox.ImageLocation = ofd.FileName;
                _db[(int)NumQuestion.Value - 1].PathImageQuestion = ImageBox.ImageLocation;
            }
        }

        private void SwithMode_Click(object sender, EventArgs e)
        {
            EditorPanel.Visible = _isGameMode;
            _isGameMode = !_isGameMode;

        }

        private void ImgAnsBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ImageBox.ImageLocation = ofd.FileName;
                _db[(int)NumQuestion.Value - 1].PathImageAnswer = ImageBox.ImageLocation;
            }
        }

        private void TrueBtn_Click(object sender, EventArgs e)
        {
            if (_db != null && _isCorrectValue)
            {
                ImageBox.ImageLocation = _db[(int) NumQuestion.Value - 1].PathImageAnswer;
                QuestionLbl.Text = _db[(int) NumQuestion.Value - 1].TextAnswer;
                if (_db[(int) NumQuestion.Value - 1].IsTrue)
                    _trueValue++;
                else
                    _falseValue++;
                TrueCoutLbl.Text = $@"{_trueValue}";
                FalseCountLbl.Text = $@"{_falseValue}";
                _isCorrectValue = !_isCorrectValue;
            }
        }

        private void SaveBtnA_Click(object sender, EventArgs e)
        {
            if (_db == null) return;
            _db[(int)NumQuestion.Value - 1].TextAnswer = QuestionTextBox.Text;
        }
    }
}
