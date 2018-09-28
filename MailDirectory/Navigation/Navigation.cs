﻿using System;
using System.Windows.Navigation;
using System.Windows.Controls;

namespace MailDirectory.Navigation
{
    //Данный класс обеспечивает страничную навигацию
    //Источник: https://github.com/homoluden/MVVM-Navigation
    //Подробное описание: https://habr.com/post/194016/

    public sealed class Navigation
    {
        #region Constants
        public static readonly string PageHomeDirectory_Alias = "HomeDirectory";
        public static readonly string PageLetter_Alias = "PageAddLetter";
        public static readonly string PageEmployee_Alias = "PageAddEmployee";

        #endregion

        #region Fields

        private NavigationService _navService;
        private readonly IPageResolver _resolver;

        #endregion


        #region Properties

        public static NavigationService Service
        {
            get { return Instance._navService; }
            set
            {
                if (Instance._navService != null)
                {
                    Instance._navService.Navigated -= Instance._navService_Navigated;
                }                
                
                Instance._navService = value;
                Instance._navService.Navigated += Instance._navService_Navigated;
            }
        }

        #endregion


        #region Public Methods

        public static void Navigate(Page page, object context)
        {
            if (Instance._navService == null || page == null)
            {
                return;
            }

            Instance._navService.Navigate(page, context);
        }

        public static void Navigate(Page page)
        {
            Navigate(page, null);
        }

        public static void Navigate(string uri, object context)
        {
            if (Instance._navService == null || uri == null)
            {
                return;
            }

            var page = Instance._resolver.GetPageInstance(uri);

            Navigate(page, context);
        }

        public static void Navigate(string uri)
        {
            Navigate(uri, null);
        }

        #endregion


        #region Private Methods

        void _navService_Navigated(object sender, NavigationEventArgs e)
        {
            if (!(e.Content is Page page))
            {
                return;
            }
            page.DataContext = e.ExtraData;
        }

        #endregion


        #region Singleton

        private static volatile Navigation _instance;
        private static readonly object SyncRoot = new Object();

        private Navigation()
        {
            _resolver = new PagesResolver();
        }

        private static Navigation Instance
        {
            get 
            {
                if (_instance == null) 
                {
                    lock (SyncRoot) 
                    {
                        if (_instance == null)
                            _instance = new Navigation();
                    }
                }

                return _instance;
            }
        }
        #endregion
    }
}
