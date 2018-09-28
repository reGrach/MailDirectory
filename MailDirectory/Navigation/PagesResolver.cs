using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace MailDirectory.Navigation
{
    //Данные интерфейс и класс обеспечивают страничную навигацию
    //Источник: https://github.com/homoluden/MVVM-Navigation
    //Подробное описание: https://habr.com/post/194016/

    public interface IPageResolver
    {
        Page GetPageInstance(string alias);
    }

    public class PagesResolver : IPageResolver
    {
        
        private readonly Dictionary<string, Func<Page>> pagesResolvers = new Dictionary<string, Func<Page>>();

        public PagesResolver()
        {
            //pagesResolvers.Add(Navigation.PageHomeDirectory_Alias, () => new HomeDirectory());
            pagesResolvers.Add(Navigation.PageLetter_Alias, () => new PageAddLetter());
            pagesResolvers.Add(Navigation.PageEmployee_Alias, () => new PageAddEmployee());
        }
        public Page GetPageInstance(string alias)
        {
            if (pagesResolvers.ContainsKey(alias))
            {
                return pagesResolvers[alias]();
            }

            return pagesResolvers["Страница не найдена"]();
        }
    }
}
