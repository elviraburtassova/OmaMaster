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
	public partial class Triangle3 : ContentPage
	{
		public Triangle3()
		{
			InitializeComponent();
		}

        private async void Tr3_Clicked(object sender, EventArgs e)
        {
			await DisplayAlert("Площадь равностороннего треугольника:", "Вычисляется как половина произведения его основания на высоту - SΔ = (a2 * √3)/ 4", "Скрыть");
		}
	}
    }
