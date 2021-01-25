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
	public partial class Triangle1 : ContentPage
	{
		Entry ent1, ent2, ent3;

		public Triangle1()
		{
			InitializeComponent();
		}
		private void trig1_Clicked(object sender, EventArgs e)
		{
			ent3.Text = "Решение:\n" + (1/2) * ((ent1) *(ent2));
		}
	}
}