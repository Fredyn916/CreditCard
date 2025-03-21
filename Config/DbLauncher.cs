using Dapper;
using System.Data.SQLite;

namespace Config;

class DbLauncher
{
    public static void Initialize()
    {
        using var connection = new SQLiteConnection("Data Source=CreditCard.db");

        //connection.Execute(DataBaseScript.CreateTables());

        //int cargoCount = connection.QueryFirst<int>(CargoScript.SelectCountAllCargos()); // Query Select na tabela para retornar o Count

        //if (cargoCount == 0) // Se a tabela 'Cargos' estiver vazia, insere os cargos
        //{
        //    connection.Execute(CargoScript.InsertCargos());
        //}
    }
}