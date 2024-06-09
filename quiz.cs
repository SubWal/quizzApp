using System.Collections.Generic;

namespace quizApp2
{
    public class Quiz
    {
        public string Title { get; set; }
        public List<Question> Questions { get; set; }
        private int currentQuestionIndex;
        private int totalPoints;

        public Quiz(string title, List<Question> questions)
        {
            Title = title;
            Questions = questions;
            currentQuestionIndex = 0;
            totalPoints = 0;
        }

        public Question GetCurrentQuestion()
        {
            if (HasMoreQuestions())
            {
                return Questions[currentQuestionIndex];
            }
            return null;
        }

        public bool HasMoreQuestions()
        {
            return currentQuestionIndex < Questions.Count;
        }

        public bool SubmitAnswer(int selectedOption)
        {
            var question = Questions[currentQuestionIndex];
            bool isCorrect = question.CorrectAnswerIndex == selectedOption;
            if (isCorrect)
            {
                totalPoints += question.Points;
            }
            return isCorrect;
        }

        public void MoveToNextQuestion()
        {
            if (HasMoreQuestions())
            {
                currentQuestionIndex++;
            }
        }

        public int GetTotalPoints()
        {
            return totalPoints;
        }

        public int GetMaxPoints()
        {
            int maxPoints = 0;
            foreach (var question in Questions)
            {
                maxPoints += question.Points;
            }
            return maxPoints;
        }
    }
}
