﻿namespace Domain.Exceptions.Base;

public class ExceptionBase : HttpRequestException
{
    public ExceptionBase(
        string message = "An error occurred",
        HttpStatusCode statusCode = HttpStatusCode.InternalServerError)
        : base(message, null, statusCode)
    {
    }
}
