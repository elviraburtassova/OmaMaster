﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OmaMaster.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Rectangle : ContentPage
	{
		public Rectangle()
		{
			InitializeComponent();
		}

        private async void Rect_Clicked(object sender, EventArgs e)
        {
			await DisplayAlert("Площадь прямоугольника:", "Равна произведению его смежных сторон - S = a * b", "Скрыть");
		}
    }
}