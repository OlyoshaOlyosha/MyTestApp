using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using static MyTestApp.SingleChoicePage;

namespace MyTestApp
{
    public partial class MultipleChoicePage : Page
    {
        public MultipleChoicePage()
        {
            InitializeComponent();
        }

        private void CheckButtonClick(object sender, RoutedEventArgs e)
        {
            if (ScoreQuestionNumber.QuestionNumber == 3)
            {
                bool checkSomeAnswer = FirstAnswer.IsChecked == true ||
                    SecondAnswer.IsChecked == true ||
                    ThirdAnswer.IsChecked == true ||
                    FourthAnswer.IsChecked == true;
                if (FirstAnswer.IsChecked == true & ThirdAnswer.IsChecked == true)
                {
                    ScoreQuestionNumber.Score += 2;
                    ScoreQuestionNumber.QuestionNumber += 1;

                    LabelQuestions.Content = "Вопрос № 4. Какие из следующих концепций являются частью инкапсуляции? (Выберите все подходящие варианты)";
                    FirstAnswer.Content = "Скрытие внутренней реализации объекта";
                    SecondAnswer.Content = "Использование открытых и закрытых методов";
                    ThirdAnswer.Content = "Создание иерархии классов";
                    FourthAnswer.Content = "Защита данных от прямого доступа извне";

                    FirstAnswer.IsChecked = false;
                    SecondAnswer.IsChecked = false;
                    ThirdAnswer.IsChecked = false;
                    FourthAnswer.IsChecked = false;
                }
                else if (checkSomeAnswer == false)
                {
                    MessageBox.Show("Вы не выбрали ни одного ответа!");
                }
                else
                {
                    MessageBox.Show("Выфввыыф!");
                    ScoreQuestionNumber.QuestionNumber += 1;
                    LabelQuestions.Content = "Вопрос № 4. Какие из следующих концепций являются частью инкапсуляции? (Выберите все подходящие варианты)";
                    FirstAnswer.Content = "Скрытие внутренней реализации объекта";
                    SecondAnswer.Content = "Использование открытых и закрытых методов";
                    ThirdAnswer.Content = "Создание иерархии классов";
                    FourthAnswer.Content = "Защита данных от прямого доступа извне";

                    FirstAnswer.IsChecked = false;
                    SecondAnswer.IsChecked = false;
                    ThirdAnswer.IsChecked = false;
                    FourthAnswer.IsChecked = false;
                }
            }
            else if (ScoreQuestionNumber.QuestionNumber == 4)
            {
                bool checkSomeAnswer = FirstAnswer.IsChecked == true ||
                    SecondAnswer.IsChecked == true ||
                    ThirdAnswer.IsChecked == true ||
                    FourthAnswer.IsChecked == true;
                if (FirstAnswer.IsChecked == true & SecondAnswer.IsChecked == true & FourthAnswer.IsChecked == true)
                {
                    ScoreQuestionNumber.Score += 2;
                    ScoreQuestionNumber.QuestionNumber += 1;
                    NavigationService.Navigate(new InputPage());
                }
                else if (checkSomeAnswer == false)
                {
                    MessageBox.Show("Вы не выбрали ни одного ответа!");
                }
                else
                {
                    MessageBox.Show("Выфввыыф!");
                    ScoreQuestionNumber.QuestionNumber += 1;
                    NavigationService.Navigate(new InputPage());
                }
            }
        }

        private void FourthAnswer_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
