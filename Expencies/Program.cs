using Expencies.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenciesUI
{
	class Program
	{
		static void Main(string[] args)
		{
			ExpenseManager expenseManager = new ExpenseManager();

			var expense =  new Expense { }
			expenseManager.Add();

		}
	}
}
