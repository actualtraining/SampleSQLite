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
            var empList = App.DBUtils.GetAllEmployee();
            lvData.ItemsSource = empList;
            lvData.ItemSelected += LvData_ItemSelected;
        }

        private void LvData_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var currEmp = e.SelectedItem as Employee;
        }
    }
}
