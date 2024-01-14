using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OVB.Challenge.Products.WebApi.Controllers.Payloads;
using System.Net.Mime;

namespace OVB.Challenge.Products.WebApi.Controllers;

[Route("api/v1/customers")]
[ApiController]
public sealed class CustomerController : ControllerBase
{
    [HttpPost]
    [Consumes(MediaTypeNames.Application.Json)]
    [Route("import")]
    [AllowAnonymous]
    public async Task<IActionResult> HttpPostImportCustomerAsync(
        [FromBody] HttpPostImportCustomerPayloadInput input,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
