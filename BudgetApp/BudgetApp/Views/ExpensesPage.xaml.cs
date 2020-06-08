using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using BudgetApp.Models;
using BudgetApp.Views;
using BudgetApp.ViewModels;

namespace BudgetApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        public ItemsPage()
        {
            InitializeComponent();
            BindingContext = Budget.OurBudget;

        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            AddExpensePage AddPage = new AddExpensePage();
            await Navigation.PushModalAsync(new NavigationPage(AddPage));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = Budget.OurBudget;
        }
    }
}