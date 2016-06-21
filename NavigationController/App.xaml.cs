using Xamarin.Forms;
using Prism.Unity;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using NavigationSample.Views;
using NavigationSample.Navigation;

namespace NavigationSample
{
    public partial class App : PrismApplication
    {

        protected override void OnStart() {
            // Handle when your app starts
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            // Handle when your app resumes
        }


        protected override async void OnInitialized() {

            InitializeComponent();

            var navi = this.Container.Resolve<NavigationController>();


            MainPage = navi.CreateTabbedPage<MainTab>(new List<NavigationPage> {
                await navi.CreateNavigationPage<ANavi,MainA>(),
                await navi.CreateNavigationPage<BNavi,MainB>(),
                await navi.CreateNavigationPage<CNavi,MainC>(),
            });

        }

        protected override void RegisterTypes() {
            this.Container.RegisterType<IApplicationProviderForNavi, ApplicationProviderForNavi>(null,new ContainerControlledLifetimeManager());
            this.Container.RegisterType<INavigationController, NavigationController>(null, new ContainerControlledLifetimeManager());
            this.Container.RegisterType<INavigationParameter, NavigationParameter>(null, new ContainerControlledLifetimeManager());
        }
    }

}

