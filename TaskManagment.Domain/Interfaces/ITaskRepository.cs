using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagment.Domain.Entities;


namespace TaskManagment.Domain.Interfaces
{
    public interface ITaskRepository
    {
        Task<IEnumerable<TaskItem>> GetAllAsync();
        Task<TaskItem?> GetByIdAsync(int id);
        Task AddAsync(TaskItem task);
        Task UpdateAsync(TaskItem task);
        Task DeleteAsync(int id);
    }
}
