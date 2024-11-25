using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppCoffeeShop
{
	internal abstract class Beverage
	{
		public double SizeInOunces { get; set; }
		public string BeverageName { get; set; }
		public double BeveragePrice { get; set; }
		public string OrderName { get; set; }
	}
}
