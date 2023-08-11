using BLL_Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace PC_Builder_DecoratorPattern.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PCComponentController : ControllerBase
{
    private readonly PCComponentService _pCComponentService;

    public PCComponentController(PCComponentService pCComponentService)
    {
        _pCComponentService = pCComponentService;
    }

    [HttpDelete("id")]
    public ActionResult Delete(int id)
    {
        var result = _pCComponentService.Delete(id);
        if (result) return Ok();
        return BadRequest();
    }
}
