using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Expense
    {

        public int Id { get; set; }
        public string ExpenseItem { get; set; }
        public decimal AmountOfExpense { get; set; }
        public string  DateOfExpense { get; set; }


    }
}
