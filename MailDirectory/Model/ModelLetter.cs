using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MailDirectory.Model
{
    //Класс модели отдельного письма
    class ModelLetter : INotifyPropertyChanged
    {
        #region fields
        private string date;        //Дата отправки письма
        private string subject;     //Тема письма
        private string sender;      //Сотрудник-отправитель
        private string recipient;   //Сотрудник-получатель
        private string textMessage; //Содержание письма
        #endregion

        #region public methods
        public string Date
        {
            get { return date; }
            set
            {
                date = value;
                OnPropertyChanged("Date");
            }
        }
        public string Subject
        {
            get { return subject; }
            set
            {
                subject = value;
                OnPropertyChanged("Subject");
            }
        }
        public string Sender
        {
            get { return sender; }
            set
            {
                sender = value;
                OnPropertyChanged("Sender");
            }
        }
        public string Recipient
        {
            get { return recipient; }
            set
            {
                recipient = value;
                OnPropertyChanged("Recipient");
            }
        }
        public string TextMessage
        {
            get { return textMessage; }
            set
            {
                textMessage = value;
                OnPropertyChanged("TextMessage");
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
