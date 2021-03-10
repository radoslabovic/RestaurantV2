using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
	public class OrderBuilder
	{
		public Table table;
		public List<Drink> drinks = new List<Drink>();
		public List<Food> foods = new List<Food>();
		public List<Ingredient> ingridients = new List<Ingredient>();
		public Order Build()
		{
			if(CanBuild())
			{
				return new Order(this);
			}
			else throw new InvalidOperationException("Can't build order!");
		}
		public OrderBuilder AddTable(Table table)
		{
			this.table = table;
			return this;
		}
		public OrderBuilder AddFood(Food food, int quantity=1)
		{
			for (int i = 0; i < quantity; i++)
			{
				this.foods.Add(food);
			}
			return this;
		}
		public OrderBuilder AddIngridient(Ingredient ingredient = null, int quantity = 1)
		{
			for (int i = 0; i < quantity; i++)
			{
				this.ingridients.Add(ingredient);
			}
			return this;
		}
		public OrderBuilder AddDrink(Drink drink, int quantity=1)
		{
			for (int i = 0; i < quantity; i++)
			{
				this.drinks.Add(drink);
			}			
			return this;
		}
		private bool CanBuild()
		{
			if (table == null) return false;
			if (!foods.Any() && !drinks.Any()) return false;
			return true;
		}
	}
}
