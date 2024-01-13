using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace shopflow.contract.Model.Entities.Global
{
    public class Error 
    {
        public ErrorCode Code { get; set; }
        public string Description { get; set; }
        public string Message { get; set; }
        public object? Data { get; set; }
    }
    public class ReturnDto<T>
    {
        [JsonIgnore]
        public int StatusCode { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Message { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T Data { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Error Error { get; set; }


        public ReturnDto<Error> GenericError(Exception err = null, ErrorCode code = ErrorCode.GENERIC_ERROR, string message = "")
        {
            return new ReturnDto<Error>
            {
                Error = new Error
                {
                    Message = message == "" ? "Error white trying to perform the action" : message,
                    Code = code,
                    Description = Enum.GetName(typeof(ErrorCode), code),
                    Data = err ?? null
                },
                StatusCode = StatusCodes.Status500InternalServerError
            };
        }

        public ReturnDto<Error> EntityNotFound(Exception err = null, string message = "")
        {
            return new ReturnDto<Error>
            {
                Error = new Error
                {
                    Message = message == "" ? "Entity not found" : message,
                    Code = ErrorCode.ENTITY_NOT_FOUND,
                    Description = Enum.GetName(typeof(ErrorCode), ErrorCode.ENTITY_NOT_FOUND)
                },
                StatusCode = StatusCodes.Status422UnprocessableEntity
            };
        }
    }
}