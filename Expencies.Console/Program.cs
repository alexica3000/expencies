using Expencies.Core.Managers;
using Expencies.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expencies.Console
{
	class Program
	{
		static void Main(string[] args)
		{
			ExpenseManager expenseManager = new ExpenseManager();

			var dateToday = DateTime.Now;

			var expense = new Expense
			{
				ExpenseId = Guid.NewGuid(),
				Name = "Milk",
				Amount = 18,
				Date = DateTime.Now,
				Location = "Mall",
				Currency = "MDL"
			};

			expenseManager.Add(expense);

			var selectedExpencies = expenseManager.Search(dateToday);

			foreach (var expence in selectedExpencies)
			{
				WriteLn(expence.Name);
			}

		}
	}
}
