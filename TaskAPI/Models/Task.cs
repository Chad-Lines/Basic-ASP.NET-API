namespace TaskAPI.Models;

public class Task
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public bool IsComplete { get; set; }
}
