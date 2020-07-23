using System;
using System.Drawing;


namespace Belive
{
    [Serializable]
    public class Question
    {
        private string _text;
        private bool _isTrue;
        private string _pathImage;

        public string Text
        {
            get => _text;
            set => _text = value;
        }

        public bool IsTrue
        {
            get => _isTrue;
            set => _isTrue = value;
        }

        public string PathImage
        {
            get => _pathImage;
            set => _pathImage = value;
        }

        public Question() { }

        public Question(string text, bool isTrue, string pathImage)
        {
            Text = text;
            IsTrue = isTrue;
            PathImage = pathImage;
        }
    }
}
