using Getway.Infrastructure.LogInterfaces;
using Getway.Models.LogModels;
using System;
using System.Collections.Generic;
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

            }
            catch (Exception e)
            {
                throw e;
            }
            return model;
        }
    }
}
