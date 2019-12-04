using Expencies.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expencies.Interfaces
{
	/// <summary>
	/// The IExpenseManager interface is used to 
	/// describe ExpenseManager functionality
	/// </summary>
	public interface IExpenseManager
    {
		/// <summary>
		/// Adds new Expense entity
		/// </summary>
		/// <param name="expense">Expense object</param>
		/// <returns>True/False</returns>
		bool Add(Expense expense);
		bool Delete(Guid expenseId);
		List<Expense> Search(DateTime date);
    }
}
