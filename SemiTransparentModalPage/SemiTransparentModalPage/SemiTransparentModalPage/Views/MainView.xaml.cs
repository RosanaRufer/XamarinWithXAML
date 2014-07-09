using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SemiTransparentModalPage.ViewModels;
using Xamarin.Forms;

namespace SemiTransparentModalPage.Views
{
    public partial class MainView: ContentPage
    {
        public MainView()
        {
            BindingContext = new MainViewModel(this);
            InitializeComponent();
        }
    }
}
