namespace TaskManagment.Domain.Interfaces;

public interface ITask 
{
    string Name { get; }
    string Description { get; set; }
}
