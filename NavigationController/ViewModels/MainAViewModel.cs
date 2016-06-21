using System;
using System.Diagnostics;
using NavigationSample.Navigation;
using NavigationSample.Views;
using Prism.Commands;
using Prism.Mvvm;

namespace NavigationSample.ViewModels
{

    public class MainAViewModel : BindableBase, INavigationAction, ITabAction, IDisposable
    {
        INavigationController NaviCtrl;

        public MainAViewModel(INavigationController navi) {
            //INavigationControllerはunityで注入される
            NaviCtrl = navi;
        }

        private DelegateCommand _NextPageCommand;
        public DelegateCommand NextPageCommand {
            get {
                return _NextPageCommand = _NextPageCommand ?? DelegateCommand.FromAsyncHandler(async () => {
                    await NaviCtrl.PushAsync<NormalPage>("1");  //ページ移動
                });
            }
        }

        private DelegateCommand _ModalCommand;
        public DelegateCommand ModalCommand {
            get {
                return _ModalCommand = _ModalCommand ?? DelegateCommand.FromAsyncHandler(async () => {
                    await NaviCtrl.PushModalAsync<ModalPage>("1"); //ページ移動（モーダル）
                });
            }
        }

       private DelegateCommand _ChangeTabCommand;
        public DelegateCommand ChangeTabCommand {
            get { return _ChangeTabCommand = _ChangeTabCommand ?? new DelegateCommand(() => {
                NaviCtrl.ChangeTab<CNavi>(); //Tab切り替え CNaviが担当しているTabに移動
            }); }
        }

        //INavigationAction適用時 PopAsyncで戻って来た場合に呼ばれる
        public void OnNavigatedBack() {
            Debug.WriteLine("戻ってきたよ");
        }
        //INavigationAction適用時 PushAsync前に呼ばれる
        public void OnNavigatedFoward() {
            Debug.WriteLine("ページ移動するよ");
        }
        //ITabAction適用時 タブが切り替わる際、移動元で呼ばれる
        public  void OnTabChangedFrom() {
            Debug.WriteLine("タブ移動するよ");
        }
        //ITabAction適用時 タブが切り替わる際、移動先で呼ばれる
        public void OnTabChangedTo(bool IsFirst) {
           Debug.WriteLine("タブ移動してきたよ");
        }

        public void Dispose() {
            Debug.WriteLine(this.GetType().Name + "を破棄するよ");
        }
    }

}

