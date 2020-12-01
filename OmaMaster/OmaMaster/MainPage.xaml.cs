using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OmaMaster
{
	public partial class MainPage : MasterDetailPage
	{
		public MainPage()
		{
			InitializeComponent();
			figuresImage.Source = ImageSource.FromFile("main.jpg");
			figuresList.ItemsSource = GetMenuList();
			var homePage = typeof(Pages.Figures);
			Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));
			IsPresented = false;
		}

		public List<MasterMenuItems> GetMenuList()
		{
			var list = new List<MasterMenuItems>();
			list.Add(new MasterMenuItems() //----------------- 1 главн
			{
				Text = "Геометрические фигуры",
				Detail = "Доп.Информация о проекте",
				ImagePath = "",
				TargetPage = typeof(Pages.Figures)
			});
			list.Add(new MasterMenuItems()//----------------------- 2 формы
			{
				Text = "Формы",
				Detail = "Немного о геометрических формах",
				ImagePath = "",
				TargetPage = typeof(Pages.Shapes)
			});
			list.Add(new MasterMenuItems()//------------------------------- 3 прямоугольн.треуг.
			{
				Text = "Прямоугольный треугольник",
				Detail = "О прямоугольном треугольнике",
				ImagePath = "",
				TargetPage = typeof(Pages.Triangle1)
			});
			list.Add(new MasterMenuItems()//---------------------------- 4 равнобедр.треуг
			{
				Text = "Равнобедренный треугольник",
				Detail = "О равнобедренном треугольнике",
				ImagePath = "",
				TargetPage = typeof(Pages.Triangle2)
			});
			list.Add(new MasterMenuItems() //----------------- 5 равносторон.треуг.
			{
				Text = "Равносторонний треугольник",
				Detail = "О равностороннем треугольнике",
				ImagePath = "",
				TargetPage = typeof(Pages.Triangle3)
			});
			list.Add(new MasterMenuItems()//----------------------- 6 квадрат
			{
				Text = "Квадрат",
				Detail = "О квадрате",
				ImagePath = "",
				TargetPage = typeof(Pages.Square)
			});
			list.Add(new MasterMenuItems()//------------------------------- 7 прямоугольник
			{
				Text = "Прямоугольник",
				Detail = "О прямоугольниках",
				ImagePath = "",
				TargetPage = typeof(Pages.Rectangle)
			});
			list.Add(new MasterMenuItems()//---------------------------- 8 параллелограм
			{
				Text = "Параллелограм",
				Detail = "О параллелограммах",
				ImagePath = "",
				TargetPage = typeof(Pages.Parallelogram)
			});
			list.Add(new MasterMenuItems()//------------------------------- 9 ромб
			{
				Text = "Ромб",
				Detail = "О ромбах",
				ImagePath = "",
				TargetPage = typeof(Pages.Rhombus)
			});
			list.Add(new MasterMenuItems()//---------------------------- 10 трапеция
			{
				Text = "Трапеция",
				Detail = "О трапециях",
				ImagePath = "",
				TargetPage = typeof(Pages.Trapeze)
			});
			return list;
		}

		private void figuresList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var SelectedMenuItem = (MasterMenuItems)e.SelectedItem;
			Type selectedPage = SelectedMenuItem.TargetPage;
			Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
			IsPresented = false;
		}
	}
}
