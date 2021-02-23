using construction.Models;
using construction.Services;
using Microsoft.AspNetCore.Mvc;

namespace construction.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BidsController : ControllerBase
  {

    private readonly BidsService _service;

    public BidsController(BidsService service)
    {
      _service = service;
    }

    [HttpPost]
    public ActionResult<Bid> Post([FromBody] Bid newBid)
    {
      try
      {
        return Ok(_service.Create(newBid));
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    // DELETE api/bricks/5
    [HttpDelete("{id}")]
    public ActionResult<string> Delete(int id)
    {
      try
      {
        return Ok(_service.Delete(id));
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

  }
}