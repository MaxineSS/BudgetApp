using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BudgetApp.ViewModels
{
    [Serializable]
    public class Budget 
    {
        public static Budget OurBudget;

        public string BudgetName { get; set; }
        public double Goal { get; set; }
        public DateTime Date { get; set; }
        public List<Expense> Expenses { get; private set; } //so nothing can set outside
        public double AmountLeft
        {
            get
            {
                return Goal - AmountSpent;
            }
        }
        public double AmountSpent
        {
            get
            {
                return Expenses.Sum(A => A.Amount);
            }
        }

        static Budget()
        {
            OurBudget = DataManager.Load();
        }

        public Budget()
        {
            Expenses = new List<Expense>();
        }

        public Budget(string budgetName, double goal, DateTime date)
        {
            BudgetName = budgetName;
            Goal = goal;
            Date = date;
            Expenses = new List<Expense>();
        }

    }
}
