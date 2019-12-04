using Expencies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expencies.Domain.Models;
using Expencies.Persistance.Repositories;
using Expencies.Domain;

namespace Expencies.Core.Managers
{
	public class ExpenseManager : IExpenseManager
	{
		private ExpenseRepository repo;

		public ExpenseManager()
		{
		}
		ExpenseManager(ExpenseRepository repo)
		{
			this.repo = repo;
		}

		private List<Expense> expenses = new List<Expense>();

		public bool Add(Expense expense)
		{
			expenses.Add(expense);

			return true;
		}

		public bool Delete(Guid expenseId)
		{
			foreach (var expense in expenses)
			{
				if (expense.ExpenseId == expenseId)
				{
					expenses.Remove(expense);

					return true;  
				}
			}

			return false;
		}

        public List<Expense> Search(SearchParams searchParams=null)
        {
            List<Expense> result = new List<Expense>();

            if (searchParams == null)
            {
                return expenses;
            }

            foreach (var expense in expenses)
            {
                if (ifExist(expense, searchParams))
                {
                    result.Add(expense);
                }
            }
            return result;
        }
        private bool ifExist(Expense expense, SearchParams searchParams)
        {
			if(
				(string.IsNullOrWhiteSpace(searchParams.Name) || expense.Name.Contains(searchParams.Name))
                 && (string.IsNullOrWhiteSpace(searchParams.Currency) || (expense.Currency == searchParams.Currency))
				 && (string.IsNullOrWhiteSpace(searchParams.Location) || (expense.Location == searchParams.Location))
				 && ((expense.Date == searchParams.Date) || (expense.Amount == searchParams.Amount))
				)
            {
				return true;
			}

			return false;
		}

        public List<Expense> Search(DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
