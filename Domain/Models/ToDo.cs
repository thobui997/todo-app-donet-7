namespace ToDoApp.API.Domain.Models;

public class ToDo
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}