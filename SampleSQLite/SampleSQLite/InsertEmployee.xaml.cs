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
    public partial class InsertEmployee : ContentPage
    {
        public InsertEmployee()
        {
            InitializeComponent();

            btnSave.Clicked += BtnSave_Clicked;
        }

        private async void BtnSave_Clicked(object sender, EventArgs e)
        {
            var newEmp = new Employee
            {
                EmpName = txtEmpName.Text,
                Designation = txtDesignation.Text,
                Department = txtDepartment.Text,
                Qualification = txtQualification.Text
            };

            try
            {
                App.DBUtils.InsertEmployee(newEmp);
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
