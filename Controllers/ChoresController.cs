namespace ToDoList.Controllers;

[ApiController]
[Route("api/chores")]
public class ChoresController : ControllerBase
{
  private readonly ChoresService _choresService;

  public ChoresController(ChoresService choresService)
  {
    _choresService = choresService;
  }

  [HttpGet]
  public ActionResult<List<Chore>> Get()
  {
    try
    {
      List<Chore> chores = _choresService.Get();
      return Ok(chores);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet("{choreId}")]
  public ActionResult<Chore> GetOne(int choreId)
  {
    try
    {
      Chore chore = _choresService.GetOne(choreId);
      return Ok(chore);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPost]
  public ActionResult<Chore> Create([FromBody] Chore choreData)
  {
    try
    {
      Chore chore = _choresService.Create(choreData);
      return Ok(chore);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
}