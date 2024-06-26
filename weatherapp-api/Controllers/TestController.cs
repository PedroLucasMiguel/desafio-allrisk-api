
using Microsoft.AspNetCore.Mvc;

namespace weatherapp_api.Controllers;

[ApiController]
[Route("api/test")]
public class TestController : ControllerBase
{
  [HttpGet("testing")]
  public string HelloApi() {
    return "Hello World!";
  }

  [HttpGet("testing2")]
  public string HelloApi2() {
    return "Hello World2!";
  }
}