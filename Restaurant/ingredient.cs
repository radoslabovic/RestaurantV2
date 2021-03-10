using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
	public class Ingredient: ICalculate
	{
		private string name;
		private double price;
		public Ingredient(string name)
		{
			this.name = name;
			GeneratePrice();
		}
		private void GeneratePrice()
		{
			price = new Random().Next(20, 100);
		}
		public double CalculatePrice()
		{
			return price;
		}
	}
}
