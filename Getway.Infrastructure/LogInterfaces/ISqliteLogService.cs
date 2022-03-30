using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getway.Infrastructure.LogInterfaces
{
    public interface ISqliteLogService:IBaseLogService
    {
        //veritabanına özgü işlemelr yapılabilir!
        ///https://docs.microsoft.com/tr-tr/dotnet/standard/data/sqlite/?tabs=netcore-cli
        ///burdan araştırıp log create yapılacka ve win ui başlacak-
        ///

        //using (var connection = new SqliteConnection("Data Source=hello.db"))
        //{
        //    connection.Open();

        //    var command = connection.CreateCommand();
        //    command.CommandText =
        //    @"
        //        SELECT name
        //        FROM user
        //        WHERE id = $id
        //    ";
        //    command.Parameters.AddWithValue("$id", id);

        //    using (var reader = command.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            var name = reader.GetString(0);

        //    Console.WriteLine($"Hello, {name}!");
        //        }
        //    }
        //}

    }
}
