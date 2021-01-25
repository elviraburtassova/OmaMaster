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
	public partial class Shapes : ContentPage
	{
		public Shapes()
		{
			InitializeComponent();
		}

		private async void For_Clicked(object sender, EventArgs e)
		{
			await DisplayAlert("Дополнительная информация", "Обычно фигурой на плоскости называют замкнутые множества, которые ограничены конечным числом линий. При этом допускаются вырождения, например: угол, луч и точка считаются геометрическими фигурами. Если все точки фигуры лежат в некоторой плоскости — она называется плоской и она может быть задана уравнением g(x, y)= 0 .Порядок(степень) фигуры — это порядок(степень) уравнения, которым она задана.", "Скрыть");
		}
	}
}