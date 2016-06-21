using System;

namespace NavigationSample.Navigation
{
    public interface INavigationAction
    {
        void OnNavigatedBack();
        void OnNavigatedFoward();
    }
}

