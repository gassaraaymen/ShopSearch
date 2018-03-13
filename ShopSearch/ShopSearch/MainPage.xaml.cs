using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShopSearch
{
	public partial class MainPage : ContentPage
	{
        List<Products> Products = new List<Products>
        {
            new Products{ Name="Gucci Hand Bag Light Brown" , Category="Almost New", Price="3000.00 SAR" , Image="Bag1.png"},
            new Products{ Name="Gucci Hand Bag Light Brown" , Category="Almost New", Price="3000.00 SAR" , Image="Bag2.png" },
            new Products{ Name="Gucci Hand Bag Light Brown" , Category="Almost New", Price="3000.00 SAR" , Image="Bag3.png"}
        };

		public MainPage()
		{
			InitializeComponent();

            NamesListView.ItemsSource = Products;

        }

        private void SearchBar_Presses(object sender , TextChangedEventArgs e)
        {
            var keyword = MainSearchbar.Text;
            NamesListView.ItemsSource = Products.Where(Products => Products.Name.ToLower().Contains(keyword.ToLower()));
        }


    }
}
