using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expencies.Domain.Models
{
    public class Expense
    {
        public Guid ExpenseId { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Currency { get; set; }


        public string ToShow()
        {
            var Result = string.Empty;
            Result += $" ExpenseId: {ExpenseId}; Name: {Name}; Amount: {Amount}[{Currency}]; Location: {Location} ";

            return Result;
        }

        public bool ToWriteInFile()
        {
            string path = "E:\\SearchResult";
            bool exists = Directory.Exists(path);

            if (!exists)
                Directory.CreateDirectory(path);

            StreamWriter sw = new StreamWriter($"{path}/result_search.txt", true);
            sw.WriteLine($" ExpenseId: {ExpenseId}; Name: {Name}; Amount: {Amount}[{Currency}]; Location: {Location} ");
            sw.Close();

            return true;
        }
    }
}