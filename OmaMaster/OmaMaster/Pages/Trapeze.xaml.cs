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
	public partial class Trapeze : ContentPage
	{
		public Trapeze()
		{
			InitializeComponent();
		}

        private async void Trap_Clicked(object sender, EventArgs e)
        {
			await DisplayAlert("Площадь трапеции:", "Равна произведению полусуммы ее оснований на высоту - S = (1/2) * (a + b) * h", "Скрыть");
    }
}