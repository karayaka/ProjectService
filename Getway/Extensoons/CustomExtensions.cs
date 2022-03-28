using Getway.Midlewares;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Getway.Extensoons
{
    static public class CustomExtensions
    {
        public static IApplicationBuilder UseCustomLog(this IApplicationBuilder application)
        {
            return application.UseMiddleware<LogMidleware>();
        }
    }
}
