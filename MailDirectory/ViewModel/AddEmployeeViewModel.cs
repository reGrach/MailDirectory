using MailDirectory.MailDB;
using System.Windows;

namespace MailDirectory.ViewModel
{
    //ViewModel для работы с страницей добавдения сотрудника
    class AddEmployeeViewModel : BaseViewModel
    {
        
        #region fields

        private string inputFirstName;      //поле для ввода имени сотрудника
        private string inputSecondName;     //поле для ввода фамилии сотрудника
        private RelayCommand addEmployee;   //команда для обработки события добавления сотрудника в базу

        #endregion

        #region methods

        public string InputFirstName
        {
            get { return inputFirstName; }
            set
            {
                inputFirstName = value;
                OnPropertyChanged("InputFirstName");
            }
        }
        public string InputSecondName
        {
            get { return inputSecondName; }
            set
            {
                inputSecondName = value;
                OnPropertyChanged("InputSecondName");
            }
        }
        public RelayCommand AddEmployee
        {
            get
            {
                return addEmployee ??
                    (addEmployee = new RelayCommand(obj =>
                    {
                        //Если поля пустые или заполнены пробелами выводим предупреждение
                        if (string.IsNullOrWhiteSpace(inputFirstName) || string.IsNullOrWhiteSpace(inputSecondName))
                            MessageBox.Show("Все поля должны быть заполнены!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        else AddEmployee2DB();
                    }));
            }
        }
        
        //Метод непосредственного добавления записи в БД
        private void AddEmployee2DB()
        {
            CatalogueBD = new CatalogueDBContext();
            CatalogueBD.Employees.Add(new Employee
            {
                FirstName = inputFirstName,
                SecondName = inputSecondName
            });
            CatalogueBD.SaveChanges();
        }

        #endregion
    }
}
