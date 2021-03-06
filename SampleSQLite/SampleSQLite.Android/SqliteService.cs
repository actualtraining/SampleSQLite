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
using SQLite.Net;
using SampleSQLite.Droid;

[assembly:Dependency(typeof(SqliteService))]
namespace SampleSQLite.Droid
{
    public class SqliteService : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "Pegawai.db3";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, sqliteFilename);
            if (!File.Exists(path))
                File.Create(path);
            var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var conn = new SQLiteConnection(plat, path);
            return conn;
        }
    }
}