using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagment.Domain.Entity;
using TaskManagment.Domain.Interfaces;
using TaskManagment.Infrastructure.Persistence;

namespace TaskManagment.Infrastructure.TaskRepository;
public class TaskRepository(TaskDbContext context) : ITaskRepository
{
    public void Add(TaskEntity task)
    {
        throw new NotImplementedException();
    }

    public void Update(Guid id, TaskEntity task)
    {
        throw new NotImplementedException();
    }

        
    public void Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<TaskEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public TaskEntity GetById(Guid Id)
    {
        throw new NotImplementedException();
    }

   
}
