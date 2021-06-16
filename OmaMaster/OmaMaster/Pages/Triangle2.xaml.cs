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
	public partial class Triangle2 : ContentPage
	{
		public Triangle2()
		{
			InitializeComponent();
		}

        private async void Tr2_Clicked(object sender, EventArgs e)
        {
			await DisplayAlert("Площадь равнобедренного треугольника:", "Необходимо вычислить произведение половины основания этого треугольника на его высоту - SΔ = 1/2 * a * ha", "Скрыть");
		}
    }
}