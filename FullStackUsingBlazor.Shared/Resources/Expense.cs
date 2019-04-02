using System;
using System.Collections.Generic;
using System.Text;

namespace FullStackUsingBlazor.Shared.Resources
{
    public class Expense
    {
        public Expense()
        {

        }
        public Expense(int id,string title,string desc,double amount,DateTime spendDate)
        {
            Id = id;
            Title = title;
            Description = desc;
            Amount = amount;
            Spendate = spendDate;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime Spendate { get; set; }
    }
}
