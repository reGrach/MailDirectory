using MailDirectory.MailDB;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MailDirectory.ViewModel
{
    //Базовый класс ViewModel
    class BaseViewModel : INotifyPropertyChanged
    {
        //поле инициализации базы данных

        internal CatalogueDBContext CatalogueBD;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
