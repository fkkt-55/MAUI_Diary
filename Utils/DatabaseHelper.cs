using diary.Models;
using NuGet.Common;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diary.Utils
{
    public class DatabaseHelper
    {
        private SQLiteAsyncConnection Database;
        private static DatabaseHelper Instance;
        private DatabaseHelper()
        {
            if (Database is not null)
            {
                return;
            }
            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            Database.CreateTableAsync<Record>();
        }


        public static DatabaseHelper GetInstanceAsync()
        {
            if (Instance == null)
            {
                Instance = new DatabaseHelper();
            }
            return Instance;
        }
        // Get all records from the database
        public async Task<List<Record>> GetRecordsAsync()
        {
            return await Database.Table<Record>().ToListAsync();
        }

        // Insert a new record into the database
        public async Task<int> InsertAsync(Record record)
        {
            return await Database.InsertAsync(record);
        }

        // Update an existing record in the database
        public async Task<int> UpdateAsync(Record record)
        {
            return await Database.UpdateAsync(record);
        }

        // Delete a record from the database
        public async Task<int> DeleteAsync(Record record)
        {
            return await Database.DeleteAsync(record);
        }


    }
}
