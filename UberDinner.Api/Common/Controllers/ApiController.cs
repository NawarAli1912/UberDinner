using Microsoft.AspNetCore.Mvc;
using UberDinner.Api.Common.Http;
using UberDinner.Domain.Shared.Primitives;

namespace UberDinner.Api.Common.Controllers;

public class ApiController : ControllerBase
{
    protected IActionResult Problem(List<Error> errors)
    {
        var firstError = errors[0];
        /*
            bla bla
        */
        HttpContext.Items[HttpContextItemKeys.ErrorCodes] = errors.Select(e => e.Code).ToList();
        return Problem(statusCode: 500, title: "Description");
    }
}