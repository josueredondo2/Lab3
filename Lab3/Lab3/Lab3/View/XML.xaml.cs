using Lab3.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab3.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class XML : ContentPage
	{
		public XML ()
		{
			InitializeComponent ();
            BindingContext = TabbedPageViewModel.GetInstance();
		}
	}
}