﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleSQLite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowEmployee : ContentPage
    {
        public ShowEmployee()
        {
            InitializeComponent();
            btnEdit.Clicked += BtnEdit_Clicked;
            btnDelete.Clicked += BtnDelete_Clicked;
        }

        private async void BtnDelete_Clicked(object sender, EventArgs e)
        {
            var alertResult = await DisplayAlert("Konfirmasi", "Apakah data " + txtName.Text + " akan didelete ?",
                "Yes", "No");
            if(alertResult)
            {
                var delEmployee = new Employee { EmpId = Convert.ToInt64(txtEmpID.Text) };
                try
                {
                    App.DBUtils.DeleteEmployee(delEmployee);
                    await Navigation.PopAsync();
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Error", ex.Message, "OK");
                }
            }
        }

        private async void BtnEdit_Clicked(object sender, EventArgs e)
        {
            var editEmployee = new Employee
            {
                EmpId = Convert.ToInt64(txtEmpID.Text),
                EmpName = txtName.Text,
                Department = txtDepartment.Text,
                Designation = txtDesignation.Text,
                Qualification = txtQualification.Text
            };
            try
            {
                App.DBUtils.UpdateEmployee(editEmployee);
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
