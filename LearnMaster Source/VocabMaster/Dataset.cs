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
            return this.solution.ToLower().Trim().Replace(" ", "") == other.solution.ToLower().Trim().Replace(" ", "") && this.description.ToLower().Trim().Replace(" ", "") == other.description.ToLower().Trim().Replace(" ", "");
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
