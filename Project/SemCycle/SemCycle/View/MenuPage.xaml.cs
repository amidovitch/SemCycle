using SemCycle.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SemCycle.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : ContentPage
	{
		MainPage RootPage { get => Application.Current.MainPage as MainPage; }
		List<HomeMenuItem> menuItems;
		public MenuPage()
		{
			InitializeComponent();

			menuItems = new List<HomeMenuItem>
			{
				new HomeMenuItem {Id = MenuItemType.First, Title="First sem" },
			};

			ListViewMenu.ItemsSource = menuItems;

			ListViewMenu.SelectedItem = menuItems[0];
			ListViewMenu.ItemSelected += async (sender, e) =>
			{
				if (e.SelectedItem == null)
					return;

				var id = (int)((HomeMenuItem)e.SelectedItem).Id;
				await RootPage.NavigateFromMenu(id);
			};


		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			switch (menuItems.Count)
			{
                case 0:
                    menuItems.Add(new HomeMenuItem { Id = MenuItemType.First, Title = "First sem" });
                    ListViewMenu.ItemsSource = null;
                    ListViewMenu.ItemsSource = menuItems;
                    break;
                case 1:
                    menuItems.Add(new HomeMenuItem { Id = MenuItemType.Second, Title = "Second sem" });
                    ListViewMenu.ItemsSource = null;
                    ListViewMenu.ItemsSource = menuItems;
                    break;
                case 2:
                    menuItems.Add(new HomeMenuItem { Id = MenuItemType.Third, Title = "Third sem" });
                    ListViewMenu.ItemsSource = null;
                    ListViewMenu.ItemsSource = menuItems;
                    break;
                case 3:
                    menuItems.Add(new HomeMenuItem { Id = MenuItemType.Fourth, Title = "Fourth sem" });
                    ListViewMenu.ItemsSource = null;
                    ListViewMenu.ItemsSource = menuItems;
                    break;
                case 4:
					menuItems.Add(new HomeMenuItem { Id = MenuItemType.Fifth, Title = "Fifth sem" });
					ListViewMenu.ItemsSource = null;
					ListViewMenu.ItemsSource = menuItems;
					break;
				case 5:
					menuItems.Add(new HomeMenuItem { Id = MenuItemType.Sixth, Title = "Sixth sem" });
					ListViewMenu.ItemsSource = null;
					ListViewMenu.ItemsSource = menuItems;
					break;
				case 6:
					menuItems.Add(new HomeMenuItem { Id = MenuItemType.Seventh, Title = "Seventh sem" });
					ListViewMenu.ItemsSource = null;
					ListViewMenu.ItemsSource = menuItems;
					break;
				case 7:
					menuItems.Add(new HomeMenuItem { Id = MenuItemType.Eight, Title = "Eight sem" });
					ListViewMenu.ItemsSource = null;
					ListViewMenu.ItemsSource = menuItems;
					break;
				default:
					break;
			}
			
		}
	}
}