using System;
using Prism.Mvvm;
using Prism.Commands;
using NavigationSample.Views;
using System.Diagnostics;
using NavigationSample.Navigation;

namespace NavigationSample.ViewModels
{
    public class NormalPageViewModel:BindableBase,INavigationAction,ITabAction,IDisposable
    {
        static int cnt = 2;
       
        INavigationController NaviCtrl;

        public NormalPageViewModel(INavigationController navi,INavigationParameter param) {
            NaviCtrl = navi;
            //パラメータを受け取る場合はINavigationParameterを指定する
            Message = param.Value as string;
            Debug.WriteLine("パラメータを受け取ったよ=>"+Message);
        }

        private DelegateCommand _NextPageCommand;
        public DelegateCommand NextPageCommand {
            get {
                return _NextPageCommand = _NextPageCommand ?? DelegateCommand.FromAsyncHandler(async () => {
                    await NaviCtrl.PushAsync<NormalPage>(cnt++.ToString());

                });
            }
        }

        private DelegateCommand _BackCommand;
        public DelegateCommand BackCommand {
            get {
                return _BackCommand = _BackCommand ?? DelegateCommand.FromAsyncHandler(async () => {
                    await NaviCtrl.GoBackAsync();   //戻る
                });
            }
        }

        private string _Message;
        public string Message {
            get { return _Message; }
            set { SetProperty(ref _Message, value); }
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
            Debug.WriteLine(GetType().Name+"を破棄するよ");
        }


    }
}

