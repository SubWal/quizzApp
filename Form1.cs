using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace quizApp2
{
    public partial class Form1 : Form
    {
        private Quiz quiz;

        public Form1()
        {
            InitializeComponent();
            InitializeQuiz();
            DisplayCurrentQuestion();
        }

        private void InitializeQuiz()
        {
            quiz = new Quiz("General Knowledge Quiz", new List<Question>
            {
                new Question("What is the capital of France?", new List<string> { "Berlin", "Madrid", "Paris", "Rome" }, 2, 10),
                new Question("Who wrote 'To Kill a Mockingbird'?", new List<string> { "Harper Lee", "Mark Twain", "Ernest Hemingway", "F. Scott Fitzgerald" }, 0, 20),
                new Question("What is the chemical symbol for water?", new List<string> { "H2O", "CO2", "O2", "NaCl" }, 0, 5),
                new Question("What is the largest planet in our Solar System?", new List<string> { "Earth", "Jupiter", "Saturn", "Neptune" }, 1, 15),
                new Question("Who painted the Mona Lisa?", new List<string> { "Vincent van Gogh", "Pablo Picasso", "Leonardo da Vinci", "Claude Monet" }, 2, 10),
                new Question("What is the longest river in the world?", new List<string> { "Amazon River", "Nile River", "Yangtze River", "Mississippi River" }, 1, 10),
                new Question("What is the hardest natural substance on Earth?", new List<string> { "Gold", "Iron", "Diamond", "Platinum" }, 2, 5),
                new Question("Who is known as the father of computers?", new List<string> { "Charles Babbage", "Alan Turing", "Bill Gates", "Steve Jobs" }, 0, 15),
                new Question("What is the speed of light?", new List<string> { "300,000 km/s", "150,000 km/s", "100,000 km/s", "200,000 km/s" }, 0, 20),
                new Question("Which planet is known as the Red Planet?", new List<string> { "Mars", "Venus", "Jupiter", "Saturn" }, 0, 5),
                new Question("Who developed the theory of relativity?", new List<string> { "Isaac Newton", "Albert Einstein", "Niels Bohr", "Nikola Tesla" }, 1, 20),
                new Question("What is the smallest country in the world?", new List<string> { "Vatican City", "Monaco", "San Marino", "Liechtenstein" }, 0, 10),
                new Question("What is the capital of Japan?", new List<string> { "Beijing", "Seoul", "Tokyo", "Bangkok" }, 2, 10),
                new Question("What is the tallest mountain in the world?", new List<string> { "K2", "Kangchenjunga", "Mount Everest", "Lhotse" }, 2, 20),
                new Question("Who wrote '1984'?", new List<string> { "George Orwell", "Aldous Huxley", "J.K. Rowling", "F. Scott Fitzgerald" }, 0, 15)
            });
        }

        private void DisplayCurrentQuestion()
        {
            if (quiz.HasMoreQuestions())
            {
                var question = quiz.GetCurrentQuestion();
                questionLabel.Text = question.Text;
                optionRadioButton1.Text = question.Options[0];
                optionRadioButton2.Text = question.Options[1];
                optionRadioButton3.Text = question.Options[2];
                optionRadioButton4.Text = question.Options[3];
                ClearRadioButtonSelection();
            }
            else
            {
                questionLabel.Text = "Quiz Over!";
                optionRadioButton1.Visible = false;
                optionRadioButton2.Visible = false;
                optionRadioButton3.Visible = false;
                optionRadioButton4.Visible = false;
                submitButton.Visible = false;
                scoreLabel.Text = $"Final Score: {quiz.GetTotalPoints()} / {quiz.GetMaxPoints()}";
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int selectedOption = GetSelectedOption();
            if (selectedOption != -1)
            {
                bool isCorrect = quiz.SubmitAnswer(selectedOption);
                if (isCorrect)
                {
                    MessageBox.Show("Correct!");
                }
                else
                {
                    var currentQuestion = quiz.GetCurrentQuestion();
                    MessageBox.Show($"Wrong! The correct answer was: {currentQuestion.Options[currentQuestion.CorrectAnswerIndex]}");
                }

                quiz.MoveToNextQuestion();
                DisplayCurrentQuestion();
            }
            else
            {
                MessageBox.Show("Please select an answer.");
            }
        }

        private int GetSelectedOption()
        {
            if (optionRadioButton1.Checked) return 0;
            if (optionRadioButton2.Checked) return 1;
            if (optionRadioButton3.Checked) return 2;
            if (optionRadioButton4.Checked) return 3;
            return -1;
        }

        private void ClearRadioButtonSelection()
        {
            optionRadioButton1.Checked = false;
            optionRadioButton2.Checked = false;
            optionRadioButton3.Checked = false;
            optionRadioButton4.Checked = false;
        }
    }
}
