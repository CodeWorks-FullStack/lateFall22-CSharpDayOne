namespace catHotel.Controllers;

[ApiController]
[Route("api/cats")]
public class CatsController : ControllerBase
{

  private readonly CatsService _catsService;

  // NOTE remember to add your transient in your startup
  public CatsController(CatsService catsService)
  {
    this._catsService = catsService;
  }


  [HttpGet]
  public ActionResult<List<Cat>> Get()
  {
    try
    {
      List<Cat> cats = _catsService.Get();
      return Ok(cats);
      //   NOTE this next one works too but is not as verbose
      //   return Ok(_catsService.Get());
    }
    catch (Exception e)
    {

      return BadRequest(e.Message);
    }
  }

  // [HttpGet("{id}")]
  // public ActionResult<Cat> Get(int id)
  // {
  //   try
  //   {
  //     Cat cat = _catsService.Get();
  //     return Ok(cats);
  //     //   NOTE this next one works too but is not as verbose
  //     //   return Ok(_catsService.Get());
  //   }
  //   catch (Exception e)
  //   {

  //     return BadRequest(e.Message);
  //   }
  // }

  [HttpPost]
  public ActionResult<Cat> Create([FromBody] Cat catData)
  {
    try
    {
      Cat cat = _catsService.Create(catData);
      return Ok(cat);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("{id}")]
  public ActionResult<string> Remove(int id)
  {
    try
    {
      string message = _catsService.Remove(id);
      return Ok(message);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }



}