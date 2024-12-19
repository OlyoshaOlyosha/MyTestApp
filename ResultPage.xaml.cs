using System.Windows.Controls;
using static MyTestApp.SingleChoicePage;
using static MyTestApp.Login;


namespace MyTestApp
{
    public partial class ResultPage : Page
    {
        public ResultPage()
        {
            InitializeComponent();
            LabelResults.Content = $"Результат {NameLastName.Name} {NameLastName.LastName}: {ScoreQuestionNumber.Score}";
        }
    }
}
