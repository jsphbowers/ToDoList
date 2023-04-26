namespace ToDoList.Services;

public class ChoresService
{

  private readonly ChoresRepository _repo;

  public ChoresService(ChoresRepository repo)
  {
    _repo = repo;
  }

  internal List<Chore> Get()
  {
    List<Chore> chores = _repo.Get();
    return chores;
  }

  internal Chore GetOne(int choreId)
  {
    Chore chore = _repo.GetOne(choreId);
    if (chore == null) throw new Exception($"There be no chore at {choreId}");
    return chore;
  }

  internal Chore Create(Chore choreData)
  {
    return _repo.Create(choreData);
  }
}