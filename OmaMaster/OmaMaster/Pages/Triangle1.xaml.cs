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
	public partial class Triangle1 : ContentPage
	{

		public Triangle1()
		{
			InitializeComponent();
		}

        private async void Tr1_Clicked(object sender, EventArgs e)
        {
			await DisplayAlert("Площадь прямоугольного треугольника:", "Равна половине произведения стороны на высоту, проведенную к этой стороне - SΔ= 1/2(a * h)", "Скрыть");
		}
    }
}
