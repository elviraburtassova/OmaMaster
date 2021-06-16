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
	public partial class Rhombus : ContentPage
	{
		public Rhombus()
		{
			InitializeComponent();
		}

        private async void Romb_Clicked(object sender, EventArgs e)
        {
			await DisplayAlert("Площадь ромба:", "Равна половине произведения диагоналей - S = (1/2) * (d1 * d2) ", "Скрыть");
		}
    }
}