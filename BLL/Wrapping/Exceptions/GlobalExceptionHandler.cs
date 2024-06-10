using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace BLL.Wrapping.Exceptions
{
    public class GlobalExceptionHandler : IExceptionHandler
    {
        private readonly ILogger<GlobalExceptionHandler> _logger;
        public GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger)
        {
            _logger = logger;
        }

        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            if (exception is NotImplementedException)
            {
                _logger.LogError(exception, "An unexpected error occurred");
                await httpContext.Response.WriteAsJsonAsync(new ErrorClass
                {
                    StatusCode = (int)HttpStatusCode.InternalServerError,
                    Title = "Internal Server Error",
                    ExceptionMessage = exception.Message,
                });
                return true;

            }
            return false;
        }



    }
}
