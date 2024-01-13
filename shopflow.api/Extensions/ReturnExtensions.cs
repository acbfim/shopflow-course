using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopflow.contract.Model.Entities.Global;

namespace shopflow.api.Extensions
{
    public static class ReturnExtensions
    {
        public static ReturnDto<T> Created<T>(this T obj)
        {
            return new ReturnDto<T>
            {
                Data = obj,
                StatusCode = StatusCodes.Status201Created,
                Message = "Created"
            };
        }

        public static ReturnDto<T> Ok<T>(this T obj)
        {
            return new ReturnDto<T>
            {
                Data = obj,
                StatusCode = StatusCodes.Status200OK,
                Message = "Success"
            };
        }

        public static ReturnDto<T> Updated<T>(this T obj)
        {
            return new ReturnDto<T>
            {
                Data = obj,
                StatusCode = StatusCodes.Status200OK,
                Message = "Updated"
            };
        }

        public static ReturnDto<T> Deleted<T>(this T deleted)
        {
            return new ReturnDto<T>
            {
                StatusCode = StatusCodes.Status200OK,
                Message = "Deleted"
            };
        }


    }
}