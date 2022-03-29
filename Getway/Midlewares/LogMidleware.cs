using Getway.Infrastructure.LogInterfaces;
using Getway.Models.Enums;
using Getway.Models.LogModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getway.Midlewares
{
    public class LogMidleware
    {
        RequestDelegate next;

        private readonly IMsSqlLogServices msSql;
        private readonly ISqliteLogService sqlite;

        public LogMidleware(RequestDelegate _next, IMsSqlLogServices _msSql, ISqliteLogService _sqlite)
        {
            next = _next;
            msSql = _msSql;
            sqlite = _sqlite;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            //requst

            var request = await FormatRequest(httpContext.Request);
            var requestLog = new LogModel() 
            {
                LogDec=request,
                LogTypes=LogTypes.request,
            };
            msSql.AddLog(requestLog);
            

            await next.Invoke(httpContext);

            //reponse

            var statusCode = await FormatResponse(httpContext.Response);

            var responseLog = new LogModel()
            {
                LogDec = "Status Code :"+ statusCode,
                LogTypes = LogTypes.response,
            };
            sqlite.AddLog(responseLog);
        }

        private async Task<string> FormatRequest(HttpRequest request)
        {
            var body = request.Body;

            request.EnableBuffering();

            var buffer = new byte[Convert.ToInt32(request.ContentLength)];
            await request.Body.ReadAsync(buffer, 0, buffer.Length);
            var bodyAsText = Encoding.UTF8.GetString(buffer);
            request.Body = body;

            return $"{request.Scheme} {request.Host}{request.Path} {request.QueryString} {bodyAsText}";
        }

        private async Task<string> FormatResponse(HttpResponse response)
        {
          
            return $"{response.StatusCode}";
        }

    }
}
