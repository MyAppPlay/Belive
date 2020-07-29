using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;


namespace Belive
{
    class TrueFalse
    {
        private string _fileName;
        private List<Question> _questions;

        public string FileName
        {
            set => _fileName = value;
        }

        public TrueFalse(string fileName)
        {
            FileName = fileName;
            _questions = new List<Question>();
        }

        public void Add(string textQ, string textA, bool isTrue, string pathImgQ, string pathImgA)
        {
            _questions.Add(new Question(textQ, textA,  isTrue, pathImgQ, pathImgA));
        }

        public void Remove(int index)
        {
            if (_questions != null && index < _questions.Count && index >= 0)
                _questions.RemoveAt(index);
        }

        public Question this[int index] => _questions[index];

        public void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            Stream stream = new FileStream(_fileName, FileMode.Create, FileAccess.Write);
            xmlSerializer.Serialize(stream, _questions);
            stream.Close();
        }

        public void Load()
        {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
                Stream stream = new FileStream(_fileName, FileMode.Open, FileAccess.Read);
                _questions = (List<Question>) xmlSerializer.Deserialize(stream);
                stream.Close();
        }

        public int Count => _questions.Count;
    }
}
