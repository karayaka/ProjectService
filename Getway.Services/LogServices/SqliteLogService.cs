using Getway.Infrastructure.LogInterfaces;
using Getway.Models.LogModels;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getway.Services.LogServices
{
    public class SqliteLogService : ISqliteLogService
    {
        public SqliteLogService() { }
        
        public LogModel AddLog(LogModel model)
        {
            try
            {
                string startupPath = Environment.CurrentDirectory;
                string[] paths = { startupPath, "AppData","logDb.db"};
                string fullPath = Path.Combine(paths);

                string query = @"
                        INSERT INTO LogTable (LogDec, LogDate, LogTypes) VALUES ( @LogDec, @LogDate, @LogTypes)
                        ";


                using (var connection = new SqliteConnection("Data Source=" + fullPath))
                {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@LogDec", model.LogDec);
                    command.Parameters.AddWithValue("@LogDate", model.LogDate.ToShortDateString());
                    command.Parameters.AddWithValue("@LogTypes", Convert.ToInt32(model.LogTypes));

                    command.ExecuteReader();

                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return model;
        }
    }
}
