using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
	public class Drink: ICalculate
	{
		private double volume;
		private string name;
		private double price;
		public Drink(string name, double volume)
		{
			this.name = name;
			this.volume = volume;
			GeneratePrice();
		}
		private void GeneratePrice()
		{
			price = new Random().Next(150, 500);
		}
		public double CalculatePrice()
		{
			return price;
		} 
	}
}
