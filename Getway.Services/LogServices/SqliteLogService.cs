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
        public async Task AddLog(LogModel model)
        {
            try
            {
                var mdl = model;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
