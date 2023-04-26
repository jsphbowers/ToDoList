namespace ToDoList.Repositories;

public class ChoresRepository
{

  private readonly FakeDB _db;

  public ChoresRepository(FakeDB db)
  {
    _db = db;
  }

  internal Chore Create(Chore choreData)
  {
    int choreId = _db.Chores[_db.Chores.Count - 1].Id + 1;
    Chore newChore = new Chore(choreData.Id, choreData.Title, choreData.Importance, choreData.Color, choreData.Description);
    _db.Chores.Add(newChore);
    return newChore;
  }

  internal List<Chore> Get()
  {
    return _db.Chores;
  }

  internal Chore GetOne(int choreId)
  {
    Chore chore = _db.Chores.Find(c => c.Id == choreId);
    return chore;
  }
}