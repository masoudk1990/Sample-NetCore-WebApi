using Contracts.IServices;
using Entities.ErrorModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using System.Net;

namespace CompanyEmployee.API.Infrastructure.Extensions
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app, ILoggerManager logger)
        {
            app.UseExceptionHandler(configure =>
            {
                configure.Run(async handler => {

                    handler.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    handler.Response.ContentType = "application/json";

                    var handlerFeature = handler.Features.Get<IExceptionHandlerFeature>();

                    if (handler != null)
                    {
                        logger.LogError($"Something went wrong: {handlerFeature.Error}");
                        await handler.Response.WriteAsync(new ErrorDetails() { 
                            StatusCode = handler.Response.StatusCode,
                            Message = "Internal Server Error."
                        }.ToString());
                    }

                });
            });
        }
    }
}
