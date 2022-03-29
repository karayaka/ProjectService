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
    }
}
