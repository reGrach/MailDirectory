using MailDirectory.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace MailDirectory
{
    /// <summary>
    /// Логика взаимодействия для HomeDirectory.xaml
    /// </summary>
    public partial class HomeDirectory : Page
    {
        public HomeDirectory()
        {
            InitializeComponent();
            Loaded += HomeDirectory_Loaded;
        }

        private void HomeDirectory_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new HomeViewModel(new ViewModelsResolver());
            Navigation.Navigation.Service = NavigationService;
        }
    }
}
