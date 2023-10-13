﻿using ApiGateway.Controllers.Base;
using Application.UserArea.Command;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiGateway.Controllers.UserArea;

public class AccountController : ApplicationController
{
    [AllowAnonymous]
    [HttpPost("sign-up")]
    public async Task<SignUpCommandResponse> SignUp([FromBody] SignUpCommand command)
    {
        var result = await Mediator.Send(command);

        return result;
    }

    [AllowAnonymous]
    [HttpPost("sign-in")]
    public async Task SignIn()
    {
        throw new NotImplementedException();
    }
}