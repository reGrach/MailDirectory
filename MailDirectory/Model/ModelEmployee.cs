using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MailDirectory.Model
{
    //Класс модели сотрудника
    class ModelEmployee : INotifyPropertyChanged
    {
        #region feilds
        private string fullName;    //Полное имя
        private string firstName;   //Имя
        private string secondName;  //Фамилия
        #endregion

        #region public methods
        public string FullName
        {
            get { return fullName; }
            set
            {
                fullName = value;
                OnPropertyChanged("FirstName");
            }
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }
        public string SecondName
        {
            get { return secondName; }
            set
            {
                secondName = value;
                OnPropertyChanged("FirstName");
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
