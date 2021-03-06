﻿using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationSample.Navigation
{
    public interface INavigationController
    {
        bool ChangeTab<TNavigationPage>();

        Task PushAsync<TContentPage>(object param = null, bool animated = true)
            where TContentPage : ContentPage;

        Task PushAsync<TNavigationPage, TContentPage>(object param = null, bool animated = true)
            where TNavigationPage : NavigationPage where TContentPage : ContentPage;

        Task PushModalAsync<TContentPage>(object param = null, bool animated = true)
            where TContentPage : ContentPage;


        Task GoBackAsync(bool animated = true);
    }
}

