using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
	public class Order
	{
		Table table;
		List<Drink> drinks = new List<Drink>();
		List<Food> foods = new List<Food>();
		List<Ingredient> ingridients = new List<Ingredient>();
		public Order(OrderBuilder builder)
		{
			if (!builder.table.IsTableOrderPayed) throw new Exception("Previous bill should be paid!");
			this.table = builder.table;
			this.table.IsTableOrderPayed = false;
			this.drinks = builder.drinks;
			this.foods = builder.foods;
			this.ingridients = builder.ingridients;
			PrintOrder();
		}
		public void PayCheck()
		{
			PrintBill();
			table.IsTableOrderPayed = true;
		}
		private void PrintBill()
		{
			double summ = drinks.Sum(d => d.CalculatePrice()) + foods.Sum(d => d.CalculatePrice()) + ingridients.Sum(d => d.CalculatePrice());
			Console.WriteLine("Bill: date {0} {1} paycheck {2} eur", DateTime.Now, table.ToString(), summ);
		}
		private void PrintOrder()
		{
			Console.WriteLine("Order: date {0} {1} paycheck", DateTime.Now, table.ToString());
		}
	}
}
