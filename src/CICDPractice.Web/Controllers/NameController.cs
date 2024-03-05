using Microsoft.AspNetCore.Mvc;

namespace CICDPractice.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class NameController : ControllerBase
{
    public string Get()
    {
        return "hello";
    }
}
