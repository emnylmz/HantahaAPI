using System;
using System.Net;
using System.Text.Json.Serialization;

namespace HantahaAPI.Core.DTOs
{
	public class CustomResponseDto<T>
	{
		public T Data { get; set; }

		//jsona dönüşürken ignore et
		[JsonIgnore]
		public int StatusCode { get; set; }

		public List<string> Errors { get; set; }

        //static factory method design pattern
        public static CustomResponseDto<T> SuccessWithData(T data, HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            return new CustomResponseDto<T> { Data = data, StatusCode = (int)statusCode};
        }

        public static CustomResponseDto<T> SuccessWithoutData(HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            return new CustomResponseDto<T> { StatusCode = (int)statusCode, Errors = null };
        }

        public static CustomResponseDto<T> FailWithErrors(List<string> errors, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
        {
            return new CustomResponseDto<T> { StatusCode = (int)statusCode, Errors = errors };
        }

        public static CustomResponseDto<T> FailWithError(string error, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
        {
            return new CustomResponseDto<T> { StatusCode = (int)statusCode, Errors = new List<string> { error } };
        }
    }
}

