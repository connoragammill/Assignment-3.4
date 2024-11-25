using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppCoffeeShop
{
	public enum Roast { light, medium, dark }
	public enum Temperature { hot, iced }
	internal class Coffee : Beverage
	{

		public string BrewStrength { get; set; }
		public Roast Roast { get; set; }
		public bool InStock { get; set; }
		public Temperature Temperature { get; set; }

	}
}
