using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
using Xamarin.Forms;

namespace SampleSQLite
{
    public class DataAccess
    {
        SQLiteConnection dbConn;

        public DataAccess()
        {
            dbConn = DependencyService.Get<ISQLite>().GetConnection();
            dbConn.CreateTable<Employee>();
        }

        public List<Employee> GetAllEmployee()
        {
            return dbConn.Query<Employee>("select * from Employee order by EmpName asc");
        }

        public int InsertEmployee(Employee employee)
        {
            try
            {
                return dbConn.Insert(employee);
            }
            catch (Exception ex)
            {
                throw new Exception("Error : " + ex.Message);
            }
        }

        public int DeleteEmployee(Employee employee)
        {
            try
            {
                return dbConn.Delete(employee);
            }
            catch (Exception ex)
            {
                throw new Exception("Error : " + ex.Message);
            }
        }

        public int UpdateEmployee(Employee employee)
        {
            try
            {
                return dbConn.Update(employee);
            }
            catch (Exception ex)
            {
                throw new Exception("Error : "+ex.Message);
            }
        } 
    }
}
