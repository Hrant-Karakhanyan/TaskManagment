namespace TaskManagment.Domain.Entity;

public class TaskEntity 
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public bool IsActive { get; set; } = true;
}