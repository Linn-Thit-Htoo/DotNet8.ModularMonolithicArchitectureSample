using Shared.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Features
{
    public class Result<T>
    {
        public T Data { get; set; }
        public string Message { get; set; }
        public EnumStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; }
        public bool IsError => !IsSuccess;

        public static Result<T> SuccessResult(string message = "Success.", EnumStatusCode statusCode = EnumStatusCode.Success)
        {
            return new Result<T> { IsSuccess = true, Message = message, StatusCode = statusCode };
        }

        public static Result<T> SuccessResult(T data, string message = "Success.", EnumStatusCode statusCode = EnumStatusCode.Success)
        {
            return new Result<T> { Data = data, IsSuccess = true, Message = message, StatusCode = statusCode };
        }

        public static Result<T> SaveSuccessResult(string message = "Saving Successful.")
        {
            return Result<T>.SuccessResult(message);
        }

        public static Result<T> UpdateSuccessResult(string message = "Updating Successful.")
        {
            return Result<T>.SuccessResult(message);
        }

        public static Result<T> DeleteSuccessResult(string message = "Deleting Successful.")
        {
            return Result<T>.SuccessResult(message);
        }

        public static Result<T> FailureResult(string message = "Fail.", EnumStatusCode statusCode = EnumStatusCode.BadRequest)
        {
            return new Result<T> { IsSuccess = false, Message = message, StatusCode = statusCode };
        }

        public static Result<T> FailureResult(Exception ex)
        {
            return new Result<T> { IsSuccess = false, Message = ex.ToString(), StatusCode = EnumStatusCode.InternalServerError };
        }

        public static Result<T> NotFoundResult(string message = "No Data Found.")
        {
            return Result<T>.FailureResult(message, EnumStatusCode.NotFound);
        }
    }
}