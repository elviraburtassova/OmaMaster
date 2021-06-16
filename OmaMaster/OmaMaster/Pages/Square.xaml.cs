using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OmaMaster.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Square : ContentPage
	{
		public Square()
		{
			InitializeComponent();
		}

        private async void Sqr_Clicked(object sender, EventArgs e)
        {
			await DisplayAlert("Площадь квадрата:", "Равна квадрату длины его стороны - S = a2", "Скрыть");
		}
    }
}