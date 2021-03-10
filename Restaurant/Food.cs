using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
	public class Food: ICalculate
	{
		private string name;
		private double price;
		public Food(string name)
		{
			this.name = name;
			GeneratePrice();
		}
		private void GeneratePrice()
		{
			price =  new Random().Next(300, 600);
		}
		public double CalculatePrice()
		{
			return price;
		}
	}
}
