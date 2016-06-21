using System;
using Xamarin.Forms;

namespace NavigationSample.Views
{
    public class MainTab:TabbedPage{

    }

    public class ANavi : NavigationPage
    {
        public ANavi() {
            Title = "Tab1";
        }
    }

    public class BNavi : NavigationPage
    {
        public BNavi() {
            Title = "Tab2";
        }
    }

    public class CNavi : NavigationPage
    {
        public CNavi() {
            Title = "Tab3";
        }
    }
}

