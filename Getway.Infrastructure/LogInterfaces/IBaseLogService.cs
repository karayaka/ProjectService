using Getway.Models.LogModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getway.Infrastructure.LogInterfaces
{
    public interface IBaseLogService
    {
        Task AddLog(LogModel model);
    }
}
