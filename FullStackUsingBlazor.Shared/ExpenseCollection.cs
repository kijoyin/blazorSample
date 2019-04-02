using FullStackUsingBlazor.Shared.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullStackUsingBlazor.Shared
{
    public static class ExpenseCollection
    {
        public static IEnumerable<Expense> Expenses = new List<Expense>()
        {
            new Expense(1,"Expense 1","This is expense one",12.65,DateTime.Now),
            new Expense(2,"Expense 2","This is expense two",135.5,DateTime.Now),
            new Expense(3,"Expense 3","This is expense three",1.775,DateTime.Now),
            new Expense(4,"Expense 4","This is expense four",32,DateTime.Now),
            new Expense(5,"Expense 5","This is expense five",5.100,DateTime.Now),
            new Expense(6,"Expense 6","This is expense 6",1235.01,DateTime.Now),
            new Expense(7,"Expense 7","This is expense 7",356.765,DateTime.Now),
            new Expense(8,"Expense 8","This is expense 8",21.8,DateTime.Now),
            new Expense(9,"Expense 9","This is expense 9",378,DateTime.Now),
            new Expense(10,"Expense 10","This is expense 10",13.6,DateTime.Now),
            new Expense(11,"Expense 11","This is expense 10",100.33,DateTime.Now)
        };
    }
}
