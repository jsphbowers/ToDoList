namespace ToDoList.Repositories;

public class FakeDB
{
  public List<Chore> Chores;

  public FakeDB()
  {
    Chores = new List<Chore>();
    Chores.Add(new Chore(1, "Get Milk", 8, "Red", "Make sure to get whole milk!"));
    Chores.Add(new Chore(2, "Do a barrel roll!", 3, "Yellow", "Press L and R at the same time to do a barrel Roll!!!"));
    Chores.Add(new Chore(3, "Sweep", 5, "Yellow", "Sweep all the pathways and trash around rides."));
    Chores.Add(new Chore(4, "Build a Plane", 8, "Green", "Whenever you get around to it, we gots to build a plane to get out of here."));
  }
}