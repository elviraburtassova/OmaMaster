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
	public partial class Figures : ContentPage
	{
		public Figures()
		{
			InitializeComponent();
		}

		private async void fig_Clicked(object sender, EventArgs e)
		{
			await DisplayAlert("Виды фигур:", "В геометрии очень много разных фигур - квадрат, луч, круг, отрезок, прямоугольник, прямая, треугольник, кривая, ломанная, овал, конус, цилиндр, сфера и т.д.", "Скрыть");
		}
	}
}