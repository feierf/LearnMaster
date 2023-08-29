using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMaster
{
    [Serializable]
    public class Dataset 
    {
        public string _question { get; set; }
        public string _description { get; set; }
        public string _solution { get; set; }
        public bool _asked { get; set; }
        public bool _answeredIncorrect { get; set; }
        public bool _isEquation { get; set; }
        public bool _isImage { get; set; }
        public Bitmap _image { get; set; }
        public string _equation { get; set; }

        public Dataset(string question, string description, string solution, bool isEquation = false, bool isImage = false, Bitmap image = null, string equation = "")
        {
            this._question = question;
            this._description = description;
            this._solution = solution;
            _asked = false;
            _answeredIncorrect = false;
            _isEquation = isEquation;
            _image = image;
            _isImage = isImage;
            _equation = equation;
        }

        public void ResetExamData()
        {
            _asked = false;
            _answeredIncorrect = false;
        }

        private int CalculateLevenshteinDistance(string s1, string s2)
        {
            int n = s1.Length;
            int m = s2.Length;
            int[,] d = new int[n + 1, m + 1];

            if (n == 0)
                return m;

            if (m == 0)
                return n;

            for (int i = 0; i <= n; d[i, 0] = i++) ;

            for (int j = 0; j <= m; d[0, j] = j++) ;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    int cost;

                    cost = s2[j - 1] == s1[i - 1] ? 0 : 1;

                    d[i, j] = Math.Min(Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1), d[i - 1, j - 1] + cost);
                }
            }

            return d[n, m];
        }

        public bool AnsweredCorrect(Dataset other)
        {
            string[] correctSolutions = this._solution.Split(';');
            string[] correctDescriptions = this._description.Split(';');
            bool solutionCorrect = false;
            bool descriptionCorrect = false;

            foreach (string s in correctSolutions)
            {
                if (solutionCorrect = other._solution.ToLower().Trim().Replace(" ", "") == s.ToLower().Trim().Replace(" ", "") 
                    || CalculateLevenshteinDistance(other._solution.ToLower().Trim().Replace(" ", ""), s.ToLower().Trim().Replace(" ", "")) <= 2)
                {
                    break;
                }
            }
            foreach (string s in correctDescriptions)
            {
                if (descriptionCorrect = other._description.ToLower().Trim().Replace(" ", "") == s.ToLower().Trim().Replace(" ", "")
                    || CalculateLevenshteinDistance(other._description.ToLower().Trim().Replace(" ", ""), s.ToLower().Trim().Replace(" ", "")) <= 2)
                {
                    break;
                }
            }

            return solutionCorrect && descriptionCorrect;
        }

        public override bool Equals(object obj)
        {
            return obj is Dataset dataset &&
                   _question == dataset._question &&
                   _description == dataset._description &&
                   _solution == dataset._solution;
        }

        public override string ToString()
        {
            return _question;
        }
    }
}
