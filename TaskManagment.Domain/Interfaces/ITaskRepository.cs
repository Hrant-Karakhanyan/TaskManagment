using TaskManagment.Domain.Entity;

namespace TaskManagment.Domain.Interfaces;

public interface ITaskRepository
{
    void Add(TaskEntity task);
    
    void Update(TaskEntity task);

    void Delete(TaskEntity task);

    TaskEntity GetByName(string name);

    List<TaskEntity> GetAll();
}
