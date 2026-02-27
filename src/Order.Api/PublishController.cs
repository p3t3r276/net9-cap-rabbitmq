using DotNetCore.CAP;
using Microsoft.AspNetCore.Mvc;

namespace Order.Api;

[Route("[controller]")]
public class PublishController : Controller
{
    [Route("send")]
    public IActionResult SendMessage([FromServices] ICapPublisher capBus)
    {
        capBus.Publish("test.show.time", DateTime.Now);

        return Ok();
    }
}
