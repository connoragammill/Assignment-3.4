using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppCoffeeShop
{
	internal class DataSource
	{
		public static List<Coffee> Coffees;

		public static void CreateData()
		{
			Coffees = new List<Coffee>()
			{
				new Coffee() {OrderName = "Brandi", BeverageName = "Black", BrewStrength = "heavy", SizeInOunces = 12.3, InStock = true, BeveragePrice = 4.49, Roast = Roast.dark, Temperature = Temperature.hot},
				new Coffee() {OrderName = "Jessie", BeverageName = "Frappe", BrewStrength = "light", SizeInOunces = 16.2, InStock = true, BeveragePrice = 5.59, Roast = Roast.light, Temperature = Temperature.iced},
				new Coffee() {OrderName = "Carl", BeverageName = "latte", BrewStrength = "heavy", SizeInOunces = 8.7, InStock = true, BeveragePrice = 3.99, Roast = Roast.dark, Temperature = Temperature.hot},
			};
		}
	}
}
