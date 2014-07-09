using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SemiTransparentModalPage.Base;
using SemiTransparentModalPage.Views;
using Xamarin.Forms;

namespace SemiTransparentModalPage.ViewModels
{
    public class MainViewModel
    {
        private ContentPage _page;
        public RelayCommand PushModalViewCommand { get; set; }

        public MainViewModel(ContentPage page)
        {
            _page = page;
            PushModalViewCommand = new RelayCommand(PushModalView);
        }

        private void PushModalView()
        {
            _page.Navigation.PushModalAsync(new ModalWindow());
        }
    }
}
