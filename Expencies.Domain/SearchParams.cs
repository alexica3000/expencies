using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expencies.Domain
{
    public class SearchParams
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public DateTime? Date { get; set; }
        public string Location { get; set; }
        public string Currency { get; set; }
    }
}
