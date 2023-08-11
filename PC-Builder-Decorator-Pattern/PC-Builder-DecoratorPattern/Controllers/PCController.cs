using BLL_Services.Interfaces;
using BLL_Services.Services.BuilderServices;
using DB_Conection_Models.Models;
using DB_Conection_Models.Models.ModelsDBO;
using Microsoft.AspNetCore.Mvc;

namespace PC_Builder_DecoratorPattern.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PCController : ControllerBase
{
    private readonly PCBuilderService _pcBuilderService;
    private readonly IService<PC> _pcService;

    public PCController(PCBuilderService builderService, IService<PC> pcService)
    {
        _pcBuilderService = builderService;
        _pcService = pcService;
    }

    [HttpGet]
    public ActionResult<List<PC>> Get()
    {
        var result = _pcService.Get();
        return Ok(result);
    }

    [HttpGet("id")]
    public ActionResult<PC> GetById(int id)
    {
        var result = _pcService.GetById(id);
        if (result != null) return Ok(result);
        return NotFound();
    }

    [HttpPost("save")]
    public async Task<IActionResult> Insert(Dictionary<string, PCComponentDBO> pcs)
    {
        var result = await _pcBuilderService.CreateNewPCs(pcs);
        if (result) return Ok();
        return BadRequest();
    }

    [HttpPut("update")]
    public ActionResult<PC> Update(PC pc)
    {
        var result = _pcService.Update(pc);
        if (result) return Ok();
        return BadRequest();
    }

    [HttpDelete("id")]
    public ActionResult Delete(int id)
    {
        var result = _pcService.Delete(id);
        if (result) return Ok();
        return BadRequest();
    }
}
