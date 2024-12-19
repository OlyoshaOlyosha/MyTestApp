using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using static MyTestApp.SingleChoicePage;

namespace MyTestApp
{
    public partial class InputPage : Page
    {
        public InputPage()
        {
            InitializeComponent();
        }

        private void CheckButtonClick(object sender, RoutedEventArgs e)
        {
            if (ScoreQuestionNumber.QuestionNumber == 5)
            {
                if (Answer.Text == "Наследование")
                {
                    ScoreQuestionNumber.Score += 4;
                    NavigationService.Navigate(new ResultPage());
                }
                else if (Answer.Text == "")
                {
                    MessageBox.Show("Вы ничего не написали!");
                }
                else
                {
                    NavigationService.Navigate(new ResultPage());
                }
            }
        }
    }
}
