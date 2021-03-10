using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
	class Program
	{
		static void Main(string[] args)
		{
			Table table1 = new Table(1);
			Table table2 = new Table(2);
			Table table3 = new Table(3);
			Table table4 = new Table(4);
			Table table5 = new Table(5);
			Food margarita = new Food("Pizza Margarita");
			Food kapricoza = new Food("Pizza Kapricoza");
			Food sicilijana = new Food("Pizza Sicilijana");
			Food pastaItaliana = new Food("Pasta Italiana");
			Ingredient origano = new Ingredient("Origano");
			Ingredient ketchup = new Ingredient("Ketchup");
			Ingredient extraCheese = new Ingredient("Extra cheese");
			Drink water = new Drink("Water", 0.5);
			Drink cocaCola = new Drink("Coca Cola", 0.5);
			Drink nonCarbonatedJuice = new Drink("Non Carbonated Juice", 0.5);
			Drink carbonatedJuice = new Drink("Non Carbonated Juice", 0.3);

			var order1 = new OrderBuilder()
					.AddTable(table1)
					.AddFood(kapricoza)
					.AddIngridient(ketchup)
					.AddIngridient(origano)
					.AddDrink(cocaCola,2)
					.Build();

			var order2 = new OrderBuilder()
					.AddTable(table2)
					.AddFood(margarita)
					.AddFood(kapricoza)
					.AddDrink(nonCarbonatedJuice)
					.Build();

			var order3 = new OrderBuilder()
					.AddTable(table3)
					.AddFood(kapricoza,3)
					.AddIngridient(ketchup,2)
					.AddIngridient(origano)
					.AddDrink(nonCarbonatedJuice)
					.AddDrink(water)
					.AddDrink(carbonatedJuice)
					.Build();

			order1.PayCheck();
			order3.PayCheck();

			var order4 = new OrderBuilder()
					.AddTable(table2)
					.AddFood(kapricoza)
					.Build();

			order2.PayCheck();

			var order5 = new OrderBuilder()
					.AddTable(table2)
					.AddFood(kapricoza)
					.Build();

			Console.ReadKey();
		}
	}
}
