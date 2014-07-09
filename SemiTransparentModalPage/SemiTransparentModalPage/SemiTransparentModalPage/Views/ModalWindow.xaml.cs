using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SemiTransparentModalPage.Views
{
    public partial class ModalWindow:ContentPage
    {
        public ModalWindow()
        {
			BindingContext = new ModalViewModel (this);
            InitializeComponent();
        }
    }
}
