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
	public partial class Parallelogram : ContentPage
	{
		public Parallelogram()
		{
			InitializeComponent();
		}

        private async void Par_Clicked(object sender, EventArgs e)
        {
			await DisplayAlert("Площадь параллелограмма:", "Равна произведению стороны на высоту, проведенную к этой стороне - S = a * ha", "Скрыть");
		}
    }
}