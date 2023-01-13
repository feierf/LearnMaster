using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabMaster
{
    [Serializable]
    public class Dataset 
    {
        public string question { get; set; }
        public string description { get; set; }
        public string solution { get; set; }
        public bool asked { get; set; }
        public bool answeredIncorrect { get; set; }

        public Dataset(string question, string description, string solution)
        {
            this.question = question;
            this.description = description;
            this.solution = solution;
            asked = false;
            answeredIncorrect = false;
        }

        public void ResetExamData()
        {
            asked = false;
            answeredIncorrect = false;
        }

        public bool AnsweredCorrect(Dataset other)
        {
            string[] correctSolutions = this.solution.Split(';');
            string[] correctDescriptions = this.description.Split(';');
            bool solutionCorrect = false;
            bool descriptionCorrect = false;

            foreach (string s in correctSolutions)
            {
                if (solutionCorrect = other.solution.ToLower().Trim().Replace(" ", "") == s.ToLower().Trim().Replace(" ", ""))
                {
                    break;
                }
            }
            foreach (string s in correctDescriptions)
            {
                if (descriptionCorrect = other.description.ToLower().Trim().Replace(" ", "") == s.ToLower().Trim().Replace(" ", ""))
                {
                    break;
                }
            }

            return solutionCorrect && descriptionCorrect;
        }

        public override bool Equals(object obj)
        {
            return obj is Dataset dataset &&
                   question == dataset.question &&
                   description == dataset.description &&
                   solution == dataset.solution;
        }

        public override string ToString()
        {
            return question;
        }
    }
}
