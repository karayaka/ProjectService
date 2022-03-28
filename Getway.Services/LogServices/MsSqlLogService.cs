using Getway.Infrastructure.LogInterfaces;
using Getway.Models.LogModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getway.Services.LogServices
{
    public class MsSqlLogService : IMsSqlLogServices
    {


        public MsSqlLogService()
        {

        }
        public async Task AddLog(LogModel model)
        {
            try
            {
                //MS Sql
                var mdl = model;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
