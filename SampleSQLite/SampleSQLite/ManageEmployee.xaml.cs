using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleSQLite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ManageEmployee : ContentPage
    {
        public ManageEmployee()
        {
            InitializeComponent();
            lvData.ItemSelected += LvData_ItemSelected;
            menuInsert.Clicked += MenuInsert_Clicked;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var empList = App.DBUtils.GetAllEmployee();
            lvData.ItemsSource = empList;
        }

        private async void MenuInsert_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InsertEmployee());
        }

        private async void LvData_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var currEmp = e.SelectedItem as Employee;

            var showEmployee = new ShowEmployee();
            showEmployee.BindingContext = currEmp;
            await Navigation.PushAsync(showEmployee);
        }
    }
}
