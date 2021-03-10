using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
	public class Table
	{
		private int tableNumber;
		private bool isTableOrderPayed = true;
		public bool IsTableOrderPayed
		{
			get { return isTableOrderPayed; }
			set { isTableOrderPayed = value; }
		
		}
		public Table(int tableNumber)
		{
			this.tableNumber = tableNumber;
		}

		public override string ToString()
		{
			return string.Format("table {0}",tableNumber);
		}
	}
}
