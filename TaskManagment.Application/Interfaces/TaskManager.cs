using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagment.Application.Interfaces
{
    public interface TaskManager
    {
        Task CreateTask(string name, string description);

        void DeleteTask(Task task);

        void UpdateTask(Task task, string description);

        Task GetTask(string name);

        List<Task> GetAllTasks(); 
    }
}
