using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TableViewWithXAML.Views;
using Xamarin.Forms;

namespace TableViewWithXAML
{
    public class App
    {
        public static Page GetMainPage()
        {
            return new NavigationPage(new MainView());
        }
    }
}
