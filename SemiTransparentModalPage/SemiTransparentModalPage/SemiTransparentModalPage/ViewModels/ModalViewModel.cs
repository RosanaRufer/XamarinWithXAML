using System;
using SemiTransparentModalPage.Base;
using Xamarin.Forms;

namespace SemiTransparentModalPage
{
	public class ModalViewModel
	{
		ContentPage _page;
		public ModalViewModel (ContentPage page)
		{
			_page = page;
			NavigateBackCommand = new RelayCommand (NavigateBack);
		}

		public RelayCommand NavigateBackCommand {
			get;
			set;
		}

		void NavigateBack ()
		{
			_page.Navigation.PopModalAsync ();
		}

	}
}

