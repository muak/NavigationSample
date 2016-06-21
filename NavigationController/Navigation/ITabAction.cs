using System;

namespace NavigationSample.Navigation
{
    public interface ITabAction
    {
        void OnTabChangedFrom();
        void OnTabChangedTo(bool IsFirst);
    }
}

