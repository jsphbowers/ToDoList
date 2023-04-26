using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models;


public class Chore
{
  public Chore(int id, string title, int importance, string color, string description)
  {
    Id = id;
    Title = title;
    Importance = importance;
    Color = color;
    Description = description;
  }

  public int Id { get; set; }
  public string Title { get; set; }

  [Range(0, 9)]
  public int Importance { get; set; } = 9;
  public string Color { get; set; }
  public string Description { get; set; }

}