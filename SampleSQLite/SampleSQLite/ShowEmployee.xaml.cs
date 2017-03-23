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
    public partial class ShowEmployee : ContentPage
    {
        public ShowEmployee()
        {
            InitializeComponent();
            btnEdit.Clicked += BtnEdit_Clicked;
        }

        private void BtnEdit_Clicked(object sender, EventArgs e)
        {
            var editEmployee = new Employee
            {
                EmpId = Convert.ToInt64(txtEmpID.Text),
                EmpName = txtName.Text,
                Department = txtDepartment.Text,
                Designation = txtDesignation.Text,
                Qualification = txtQualification.Text
            };

        }
    }
}
