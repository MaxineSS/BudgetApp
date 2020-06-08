using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BudgetApp.ViewModels
{
    [Serializable]
    public class Expense
    {
        public enum ExpenseCategory
        {
            Food,
            Transportation,
            Household,
            Health,
            Education,
        }
        public string Name { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string Icon { get; set; }
        public ExpenseCategory Category { get; set; }

        public Expense()
        {

        }

        public Expense(int amount)
        {
            Amount = amount;
        }

        public Expense(string filename, DateTime date, ExpenseCategory category, int amount)
        {
            Name = filename;
            Amount = amount;
            Date = date;
            Category = category;
            Icon = $"Resources/drawable/icon_"+ category.ToString().ToLower() + ".png";
        }
    }

}
