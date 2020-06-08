using BudgetApp.Models;
using BudgetApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BudgetApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddExpensePage : ContentPage
    {
        public Expense expense { get; set; }


        public AddExpensePage()
        {
            InitializeComponent();

            expense = new Expense();

        }


        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            
            expense = (Expense)BindingContext;
            Budget.OurBudget.Expenses.Add(expense);
            DataManager.Save(Budget.OurBudget);
            await Navigation.PopModalAsync();
        }

        private async void CancelButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}