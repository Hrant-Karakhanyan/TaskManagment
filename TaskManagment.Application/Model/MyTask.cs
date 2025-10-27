using TaskManagment.Domain.Interfaces;

namespace TaskManagment.Application.Model;

public class MyTask(string name, string description) : ITask
{
    public string Name { get; } = name;
    public string Description { get; set; } = description;
}
