using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diary.Models
{
    public static class Constants
    {
        public const string DatabaseFilename = "diary.db";

        public const SQLite.SQLiteOpenFlags Flags =
            // open the Database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the Database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded Database access
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath =>
            Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);
    }
}
