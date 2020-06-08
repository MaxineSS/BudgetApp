using BudgetApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BudgetApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddBudget : ContentPage
    {
        public Budget budget { get; set; }
        public Expense expense { get; set; }
        public AddBudget()
        {
            InitializeComponent();
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            budget = (Budget)BindingContext;
            DataManager.Save(budget);
            Budget.OurBudget = budget;
            await Navigation.PopModalAsync();
        }

    }
}