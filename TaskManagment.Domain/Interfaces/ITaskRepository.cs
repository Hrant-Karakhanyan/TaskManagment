using TaskManagment.Domain.Entity;

namespace TaskManagment.Domain.Interfaces;

public interface ITaskRepository
{
    void Add(TaskEntity task);
    
    void Update(Guid id, TaskEntity task);

    void Delete(Guid id);

    TaskEntity GetById(Guid Id);

    IEnumerator<TaskEntity> GetAll();
}
