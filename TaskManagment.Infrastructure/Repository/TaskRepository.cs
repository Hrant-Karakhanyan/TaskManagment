using Microsoft.EntityFrameworkCore;
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
    public async Task AddAsync(TaskEntity task)
    {
        context.Tasks.Add(task);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(TaskEntity task)
    {
        context.Tasks.Update(task);
        await context.SaveChangesAsync();
    }


    public async Task DeleteAsync(Guid id)
    {
        
        TaskEntity? entityToDelete = await context.Tasks.FirstOrDefaultAsync(t => t.Id == id);

        if (entityToDelete != null)
        {
            
            context.Tasks.Remove(entityToDelete);
            await context.SaveChangesAsync();
        }
    }

    public async Task<TaskEntity?> GetByIdAsync(Guid Id)
    {
        
        TaskEntity? entity = await context.Tasks.FirstOrDefaultAsync(t => t.Id == Id);
        return entity;
    }

    public async Task<IEnumerator<TaskEntity>> GetAllAsync()
    {
        return (IEnumerator<TaskEntity>)await context.Tasks.ToListAsync();
    }
}