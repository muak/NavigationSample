using System;
using Prism.Mvvm;
using System.Diagnostics;
using NavigationSample.Navigation;

namespace NavigationSample.ViewModels
{
    public class MainCViewModel:BindableBase,INavigationAction,ITabAction,IDisposable
    {
        public MainCViewModel() {
        }

        public void OnNavigatedBack() {
            Debug.WriteLine("戻ってきたよ");
        }

        public void OnNavigatedFoward() {
            Debug.WriteLine("ページ移動するよ");
        }

        public void OnTabChangedFrom() {
            Debug.WriteLine("タブ移動するよ");
        }

        public void OnTabChangedTo(bool IsFirst) {
            Debug.WriteLine("タブ移動してきたよ");
        }

        public void Dispose() {
            Debug.WriteLine(GetType().Name + "を破棄するよ");
        }
    }
}

