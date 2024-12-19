using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MyTestApp
{
    public partial class SingleChoicePage : Page
    {
        public static class ScoreQuestionNumber
        {
            public static int Score { get; set; } = 0;
            public static int QuestionNumber { get; set; } = 1;
        }

        public SingleChoicePage()
        {
            InitializeComponent();
            LabelQuestions.Content = "Какой из следующих принципов не относится к основным принципам ООП?";
            FirstAnswer.Content = "Инкапсуляция";
            SecondAnswer.Content = "Наследование";
            ThirdAnswer.Content = "Полиморфизм";
            FourthAnswer.Content = "Процедурное программирование";
        }

        private void CheckButtonClick(object sender, RoutedEventArgs e)
        {
            if (ScoreQuestionNumber.QuestionNumber == 1)
            {
                bool checkSomeAnswer = FirstAnswer.IsChecked == true ||
                    SecondAnswer.IsChecked == true ||
                    ThirdAnswer.IsChecked == true ||
                    FourthAnswer.IsChecked == true;
                if (FourthAnswer.IsChecked == true)
                {
                    ScoreQuestionNumber.Score += 1;
                    ScoreQuestionNumber.QuestionNumber += 1;

                    LabelQuestions.Content = "Вопрос № 2. Что такое класс в ООП?";
                    FirstAnswer.Content = "Экземпляр объекта";
                    SecondAnswer.Content = "Шаблон для создания объектов";
                    ThirdAnswer.Content = "Функция, выполняющая операции";
                    FourthAnswer.Content = "Переменная, хранящая данные";
                }
                else if (checkSomeAnswer == false)
                {
                    MessageBox.Show("Вы не выбрали ни одного ответа!");
                }
                else
                {
                    MessageBox.Show("Выфввыыф!");
                    ScoreQuestionNumber.QuestionNumber += 1;
                    LabelQuestions.Content = "Вопрос № 2. Что такое класс в ООП?";
                    FirstAnswer.Content = "Экземпляр объекта";
                    SecondAnswer.Content = "Шаблон для создания объектов";
                    ThirdAnswer.Content = "Функция, выполняющая операции";
                    FourthAnswer.Content = "Переменная, хранящая данные";
                }
            }
            else if (ScoreQuestionNumber.QuestionNumber == 2)
            {
                bool checkSomeAnswer = FirstAnswer.IsChecked == true ||
                    SecondAnswer.IsChecked == true ||
                    ThirdAnswer.IsChecked == true ||
                    FourthAnswer.IsChecked == true;
                if (SecondAnswer.IsChecked == true)
                {
                    ScoreQuestionNumber.Score += 1;
                    ScoreQuestionNumber.QuestionNumber += 1;
                    NavigationService.Navigate(new MultipleChoicePage());
                }
                else if (checkSomeAnswer == false)
                {
                    MessageBox.Show("Вы не выбрали ни одного ответа!");
                }
                else
                {
                    MessageBox.Show("Выфввыыф!");
                    ScoreQuestionNumber.QuestionNumber += 1;
                    NavigationService.Navigate(new MultipleChoicePage());
                }
            }
        }
    }
}
