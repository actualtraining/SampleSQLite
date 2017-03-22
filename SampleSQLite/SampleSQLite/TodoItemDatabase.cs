using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;

namespace SampleSQLite
{
    
    public class TodoItemDatabase
    {
        SQLiteConnection database;

        public TodoItemDatabase()
        {
            database = DependencyService.Get<>();
        }
    }
}
