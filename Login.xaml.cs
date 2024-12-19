using System.Windows;
using System.Windows.Controls;

namespace MyTestApp
{
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        public static class NameLastName
        {
            public static string Name { get; set; } = string.Empty;
            public static string LastName { get; set; } = string.Empty;
        }

        private void LoginButtonClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new SingleChoicePage();
        }

        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            NameLastName.Name = Name.Text;
        }

        private void LastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            NameLastName.LastName = LastName.Text;
        }

    }
}
