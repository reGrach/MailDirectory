using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailDirectory.ViewModel
{
    //Данные интерфейс и класс обеспечивают страничную навигацию
    //Источник: https://github.com/homoluden/MVVM-Navigation
    //Подробное описание: https://habr.com/post/194016/

    public interface IViewModelsResolver
    {
        INotifyPropertyChanged GetViewModelInstance(string alias);
    }

    public class ViewModelsResolver : IViewModelsResolver
    {

        private readonly Dictionary<string, Func<INotifyPropertyChanged>> _vmResolvers = new Dictionary<string, Func<INotifyPropertyChanged>>();

        public ViewModelsResolver()
        {
            _vmResolvers.Add(HomeViewModel.PageAddLetterlAlias, () => new AddLetterViewModel());
            _vmResolvers.Add(HomeViewModel.PageAddEmployeelAlias, () => new AddEmployeeViewModel());
            //_vmResolvers.Add(AddEmployeeViewModel.PageHomeDirectoryAlias, () => new HomeViewModel());

        }

        public INotifyPropertyChanged GetViewModelInstance(string alias)
        {
            if (_vmResolvers.ContainsKey(alias))
            {
                return _vmResolvers[alias]();
            }

            return _vmResolvers["Страница не найдена"]();
        }
    }
}
