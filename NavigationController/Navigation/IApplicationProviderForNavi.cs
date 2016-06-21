using System;
using Xamarin.Forms;

namespace NavigationSample.Navigation
{
    public interface IApplicationProviderForNavi
    {
        Page MainPage { get; set; }
        Action<object, ModalPoppedEventArgs> ModalPopped { get; set; }
    }
}

