using System;


namespace Belive
{
    [Serializable]
    public class Question
    {
        private string _textQ;
        private string _textA;
        private bool _isTrue;
        private string _pathImageQ;
        private string _pathImageA;


        public string TextQuestion
        {
            get => _textQ;
            set => _textQ = value;
        }
        public string TextAnswer
        {
            get => _textA;
            set => _textA = value;
        }

        public bool IsTrue
        {
            get => _isTrue;
            set => _isTrue = value;
        }

        public string PathImageQuestion
        {
            get => _pathImageQ;
            set => _pathImageQ = value;
        }

        public string PathImageAnswer
        {
            get => _pathImageA;
            set => _pathImageA = value;
        }

        public Question() { }

        public Question(string textQ, string textA, bool isTrue, string pathImageQ, string pathImageA)
        {
            TextQuestion = textQ;
            TextQuestion = textA;
            IsTrue = isTrue;
            PathImageQuestion = pathImageQ;
            PathImageAnswer = pathImageA;
        }
    }
}
