using System.Collections.Generic;

namespace quizApp2
{
    public class Question
    {
        public string Text { get; set; }
        public List<string> Options { get; set; }
        public int CorrectAnswerIndex { get; set; }
        public int Points { get; set; }

        public Question(string text, List<string> options, int correctAnswerIndex, int points)
        {
            Text = text;
            Options = options;
            CorrectAnswerIndex = correctAnswerIndex;
            Points = points;
        }
    }
}
