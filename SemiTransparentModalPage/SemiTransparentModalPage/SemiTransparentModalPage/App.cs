using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SemiTransparentModalPage.Views;
using Xamarin.Forms;

namespace SemiTransparentModalPage
{
    public class App
    {
        public static Page GetMainPage()
        {
            return new NavigationPage(new MainView());
        }
    }
}
