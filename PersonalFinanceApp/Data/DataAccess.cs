using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using Dapper;

namespace PersonalFinanceApp.Data
{
    public class DataAccess
    {
        public const string Table = "History";

        public List<History> GetData()
        {
            using (var conn = new SQLiteConnection(Helper.GetConString()))
            {
                return conn.Query<History>($"SELECT * FROM {Table}", new DynamicParameters()).ToList();
            }
        }

        public void InsertData(string date, string type, string category, string amount, string total, string comment)
        {
            using (var conn = new SQLiteConnection(Helper.GetConString()))
            {
                var history = new History
                {
                    AddDate = date,
                    FinanceType = type,
                    Category = category,
                    Amount = amount,
                    Total = total,
                    Comment = comment
                };

                conn.Execute($"INSERT INTO {Table} (AddDate, FinanceType, Category, Amount, Total, Comment)" +
                    "VALUES (@AddDate, @FinanceType, @Category, @Amount, @Total, @Comment)",
                    history
                );   
            }
        }
    }
}
