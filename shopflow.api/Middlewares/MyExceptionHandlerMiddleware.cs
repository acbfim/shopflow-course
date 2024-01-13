using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using shopflow.contract.Exceptions;
using shopflow.contract.Model.Entities.Global;

namespace shopflow.api.Middlewares
{
    public class MyExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public MyExceptionHandlerMiddleware(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                context.Response.ContentType = "applications/json";

                var retError = new ReturnDto<Error>();

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    DefaultValueHandling = DefaultValueHandling.Ignore
                };



                if(ex is EntityNotFoundException)
                {
                    retError = retError.EntityNotFound(ex, ex.Message);
                    context.Response.StatusCode = retError.StatusCode;

                    await context.Response.WriteAsync(JsonConvert.SerializeObject(retError, settings));
                    return;
                }

                if(ex is NullReferenceException)
                {

                }

                var retGeneric = retError.GenericError(ex, ErrorCode.GENERIC_ERROR,ex.Message);

                context.Response.StatusCode = (int)retGeneric.StatusCode;
                await context.Response.WriteAsync(JsonConvert.SerializeObject(retGeneric,settings));
                return;


                throw;
            }
        }
    }
}