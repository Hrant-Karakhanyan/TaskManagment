using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagment.Domain.Entity;

namespace TaskManagment.Application.Interfaces
{
    public interface ITaskManager 
    {
        ITask CreateTask(string name, string description);

        void DeleteTask(ITask task);

        void UpdateTask(ITask task, string description);

        ITask GetTask(string name);

        List<ITask> GetAllTasks(); 
    }
}
