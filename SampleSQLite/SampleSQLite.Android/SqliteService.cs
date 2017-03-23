using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;


using System.IO;
using Xamarin.Forms;
using SQLite;

namespace SampleSQLite.Droid
{
    public class SqliteService
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "Pegawai.db3";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, sqliteFilename);
            if (!File.Exists(path))
                File.Create(path);
            
        }
    }
}