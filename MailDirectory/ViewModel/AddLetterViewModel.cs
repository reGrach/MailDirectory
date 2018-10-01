using MailDirectory.MailDB;
using MailDirectory.Model;
using System;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Windows;

namespace MailDirectory.ViewModel
{
    //ViewModel для работы с страницей добавдения письма
    class AddLetterViewModel : BaseViewModel
    {
        #region fields
        private ModelEmployee selectedSender;       //Поле выбранного отправителя
        private ModelEmployee selectedRecipient;    //Поле выбранного получателя
        private string inputSubject;                //Поле темы письма
        private string inputMessage;                //Поле ввода текста письма
        private DateTime inputDateTime;             //Поле даты отправления
        public ObservableCollection<ModelEmployee> Employees { get; set; } //Активный список сотрудников
        private RelayCommand addLetter;             //команда для обработки события добавления письма в базу
        #endregion

        #region public methods
        public ModelEmployee SelectedSender
        {
            get { return selectedSender; }
            set
            {
                selectedSender = value;
                OnPropertyChanged("SelectedSender");
            }
        }
        public ModelEmployee SelectedRecipient
        {
            get { return selectedRecipient; }
            set
            {
                selectedRecipient = value;
                OnPropertyChanged("SelectedRecipient");
            }
        }
        public string InputSubject
        {
            get { return inputSubject; }
            set
            {
                inputSubject = value;
                OnPropertyChanged("InputSubject");
            }
        }
        public string InputMessage
        {
            get { return inputMessage; }
            set
            {
                inputMessage = value;
                OnPropertyChanged("InputMessage");
            }
        }
        public DateTime InputDateTime
        {
            get { return inputDateTime; }
            set
            {
                inputDateTime = value;
                OnPropertyChanged("InputDateTime");
            }
        }
        public RelayCommand AddLetter
        {
            get
            {
                return addLetter ??
                    (addLetter = new RelayCommand(obj =>
                    {
                        if (string.IsNullOrWhiteSpace(inputSubject))
                            MessageBox.Show("Нельзя создать письмо без темы!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        else AddLetter2DB();
                    }, (obj) => Employees.Count > 0));
            }
        }
        #endregion

        #region private methods
        //Метод непосредственного добавления записи о новом письме в БД
        private void AddLetter2DB()
        {
            CatalogueBD = new CatalogueDBContext();
            CatalogueBD.Letters.Add(new Letter
            {
                Date = inputDateTime,
                Subject = inputSubject,
                TextMessage = inputMessage,
                SenderId = FoundEmployee(selectedSender, CatalogueBD.Employees).First().Id,
                RecipientId = FoundEmployee(selectedRecipient, CatalogueBD.Employees).First().Id
            });
            CatalogueBD.SaveChanges();
        }

        //Метод для поиска сотрудника в БД
        private IQueryable<Employee> FoundEmployee(ModelEmployee sel, DbSet<Employee> employees)
        {
            var found = from emp in employees
                        where emp.SecondName == sel.SecondName && emp.FirstName == sel.FirstName
                        select emp;
            return found;
        }
        #endregion

        #region constructors
        public AddLetterViewModel()
        {
            CatalogueBD = new CatalogueDBContext();
            Employees = new ObservableCollection<ModelEmployee>();
            //Заполнение списка сотрудников из базы
            foreach (Employee emp in CatalogueBD.Employees.Include(x => x.Letters).ToList())
            {
                Employees.Add(new ModelEmployee()
                {
                    FirstName = emp.FirstName,
                    SecondName = emp.SecondName,
                    FullName = emp.FirstName + " " + emp.SecondName
                });
            }
            if(Employees.Count > 0) //Назначаем начальные значения для combobox
            {
                selectedSender = Employees[0];
                selectedRecipient = Employees[0];
            }
            inputDateTime = DateTime.Now;
        }
        #endregion

    }
}
