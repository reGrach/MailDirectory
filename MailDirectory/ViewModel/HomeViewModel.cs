using MailDirectory.MailDB;
using MailDirectory.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace MailDirectory.ViewModel
{
    class HomeViewModel : BaseViewModel
    {

        #region feilds for navigate
        private readonly IViewModelsResolver _resolver;
        private readonly INotifyPropertyChanged pAddLetterViewModel;
        private readonly INotifyPropertyChanged pAddEmployeeViewModel;
        internal static readonly string PageAddLetterlAlias = "PageAddLetter";
        internal static readonly string PageAddEmployeelAlias = "PageAddEmployee";
        private ICommand openPageAddLetterCommand;
        private ICommand openPageAddEmployeeCommand;
        #endregion
        
        #region fields
        private ModelLetter selectedLetter;  //Поле выбранного письма в DataGrid
        public ObservableCollection<ModelLetter> Letters { get; set; } //Коллекция писем
        private RelayCommand removeLetter;   //Команда на удаление выбранного письма
        #endregion

        #region public methods

        public ModelLetter SelectedLetter
        {
            get { return selectedLetter; }
            set
            {
                selectedLetter = value;
                OnPropertyChanged("SelectedLetter");
            }
        }
        public RelayCommand RemoveLetter
        {
            get
            {
                return removeLetter ??
                    (removeLetter = new RelayCommand(obj =>
                    {
                        if (MessageBox.Show(
                            "Вы уверены, что хотите удалить писмо?",
                            "Удаление письма",
                            MessageBoxButton.YesNo,
                            MessageBoxImage.Question) == MessageBoxResult.Yes) DelLetter4DB();
                    }, (obj) => Letters.Count > 0));
            }
        }
        #endregion

        #region methods for navigate
        //Навигация для страницы добавления письма
        public ICommand OpenPageAddLetterCommand
        {
            get
            {
                return openPageAddLetterCommand;
            }
            set
            {
                openPageAddLetterCommand = value;
                OnPropertyChanged("OpenPageAddLetterCommand");
            }
        }
        public INotifyPropertyChanged AddLetterViewMode
        {
            get { return pAddLetterViewModel; }
        }
        private void OpenPageAddLetterCommandExecute(INotifyPropertyChanged viewModel)
        {
            Navigation.Navigation.Navigate(Navigation.Navigation.PageLetter_Alias, AddLetterViewMode);
        }
        //Навигация для страницы добавления сотрудника
        public ICommand OpenPageAddEmployeeCommand
        {
            get
            {
                return openPageAddEmployeeCommand;
            }
            set
            {
                openPageAddEmployeeCommand = value;
                OnPropertyChanged("OpenPageAddEmployeeCommand");
            }
        }
        public INotifyPropertyChanged AddEmployeeViewMode
        {
            get { return pAddEmployeeViewModel; }
        }
        private void OpenPageAddEmployeeCommandExecute(INotifyPropertyChanged viewModel)
        {
            Navigation.Navigation.Navigate(Navigation.Navigation.PageEmployee_Alias, AddEmployeeViewMode);
        }
        #endregion

        #region constructors
        public HomeViewModel(IViewModelsResolver resolver)
        {
            //Блок для обеспечения навигации по страницам
            _resolver = resolver;
            pAddLetterViewModel = _resolver.GetViewModelInstance(PageAddLetterlAlias);
            pAddEmployeeViewModel = _resolver.GetViewModelInstance(PageAddEmployeelAlias);
            OpenPageAddLetterCommand = new RelayCommand<INotifyPropertyChanged>(OpenPageAddLetterCommandExecute);
            OpenPageAddEmployeeCommand = new RelayCommand<INotifyPropertyChanged>(OpenPageAddEmployeeCommandExecute);
            //наполняем DG при инициализации
            DataGridUpdate();
        }
        #endregion

        #region private methods
        //Обновление DataGrid данными из БД
        private void DataGridUpdate()
        {
            CatalogueBD = new CatalogueDBContext();
            Letters = new ObservableCollection<ModelLetter>();
            foreach (Letter let in CatalogueBD.Letters.Include(x => x.Sender).ToList())
            {
                Letters.Add(new ModelLetter()
                {
                    Date = let.Date.ToShortDateString(),
                    Subject = let.Subject,
                    Sender = let.Sender.FirstName + " " + let.Sender.SecondName,
                    Recipient = let.Recipient.FirstName + " " + let.Recipient.SecondName,
                    TextMessage = let.TextMessage
                });
            }
        }
        //Удаление письма из БД
        private void DelLetter4DB()
        {
            CatalogueBD = new CatalogueDBContext();
            var foundLet = from lett in CatalogueBD.Letters
                           where lett.Subject == selectedLetter.Subject && lett.TextMessage == selectedLetter.TextMessage
                           select lett;
            CatalogueBD.Letters.Remove(foundLet.First());
            CatalogueBD.SaveChanges();
            Letters.Remove(selectedLetter);
        }
        #endregion
    }
}
