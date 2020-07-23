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

        public MainForm()
        {
            InitializeComponent();
            LoadPathDb();
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
                _db.Add("test", true, ImageBox.ImageLocation);
                _db.Save();
                
                NumQuestion.Minimum = 1;
                NumQuestion.Maximum = 1;
                NumQuestion.Value = 1;
            }
        }

        private void SavePathDb(string path)
        {
            StreamWriter sw = new StreamWriter("data.txt");
            sw.Write(path);
            sw.Dispose();
        }

        private void LoadPathDb()
        {
            StreamReader sr = new StreamReader("data.txt");
            _pathSave = sr.ReadToEnd();
            sr.Dispose();
        }

        private void NumQuestion_ValueChanged(object sender, EventArgs e)
        {
            QuestionLbl.Text = _db[(int)NumQuestion.Value - 1].Text;
            TrueFalseCheck.Checked = _db[(int)NumQuestion.Value - 1].IsTrue;
            ImageBox.ImageLocation = _db[(int) NumQuestion.Value - 1].PathImage;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (_db == null)
            {
                MessageBox.Show(@"Создайте новую базу данных", @"Сообщение");
                return;
            }
            _db.Add((_db.Count + 1).ToString(), true, ImageBox.ImageLocation);
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

        private void LoadParam(string path )
        {
            _db = new TrueFalse(path);
            _db.Load();
            //QuestionLbl.Width = 
            NumQuestion.Minimum = 1;
            NumQuestion.Maximum = _db.Count;
            NumQuestion.Value = 1;
            QuestionLbl.Parent = ImageBox;
            QuestionLbl.BackColor = Color.Transparent;
            CounterLbl.Parent = ImageBox;
            CounterLbl.BackColor = Color.Transparent;
            TrueCoutLbl.Parent = ImageBox;
            TrueCoutLbl.BackColor = Color.Transparent;
            FalseCountLbl.Parent = ImageBox;
            FalseCountLbl.BackColor = Color.Transparent;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (_db == null) return;
            _db[(int)NumQuestion.Value - 1].Text = QuestionTextBox.Text;
            _db[(int)NumQuestion.Value - 1].IsTrue = TrueFalseCheck.Checked;
            _db[(int) NumQuestion.Value - 1].PathImage = ImageBox.ImageLocation;
        }

        private void AddImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ImageBox.ImageLocation = ofd.FileName;
            }
        }

        private void SwithMode_Click(object sender, EventArgs e)
        {
            _isGameMode = !_isGameMode;

            AddBtn.Visible = _isGameMode;
            AddImgBtn.Visible = _isGameMode;
            DelBtn.Visible = _isGameMode;
            ImgAnsBtn.Visible = _isGameMode;
            SaveBtn.Visible = _isGameMode;
            NumQuestion.Visible = _isGameMode;
            TrueFalseCheck.Visible = _isGameMode;
            QuestionTextBox.Visible = _isGameMode;

            TrueBtn.Visible = !_isGameMode;
            FalseBtn.Visible = !_isGameMode;
        }
    }
}
