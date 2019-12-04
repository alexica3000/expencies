using Expencies.Core.Managers;
using Expencies.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expencies.ConsoleApp
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


            expense = new Expense
            {
                ExpenseId = Guid.NewGuid(),
                Name = "Bread",
                Amount = 20,
                Date = DateTime.Now.AddDays(-7),
                Location = "Mall",
                Currency = "MDL"
            };

            expenseManager.Add(expense);


            expense = new Expense
            {
                ExpenseId = Guid.NewGuid(),
                Name = "Bread",
                Amount = 20,
                Date = DateTime.Now,
                Location = "Mall",
                Currency = "MDL"
            };

            expenseManager.Add(expense);

            List<Expense> selectedExpencies = expenseManager.Search();

			foreach (var expence in selectedExpencies)
			{
                System.Console.WriteLine(expense.ToShow());
                

            }

			System.Console.ReadKey();
		}
	}
}
