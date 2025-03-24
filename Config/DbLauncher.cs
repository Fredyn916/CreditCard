using Config.Script;
using Dapper;
using System.Data.SQLite;

namespace Config;

public static class DbLauncher
{
    public static void Initialize()
    {
        using var connection = new SQLiteConnection("Data Source=CreditCard.db");

        connection.Execute(DataBaseScript.CreateTables());
    }
}