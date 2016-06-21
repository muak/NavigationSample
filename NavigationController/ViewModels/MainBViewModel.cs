using System;
using System.Diagnostics;
using NavigationSample.Navigation;
using Prism.Mvvm;

namespace NavigationSample.ViewModels
{
    public class MainBViewModel: BindableBase, INavigationAction, ITabAction, IDisposable
    {
        public MainBViewModel() {
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

