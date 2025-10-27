using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagment.Application.Model;

namespace TaskManagment.Application.Interfaces
{
    public interface ITaskManager 
    {
        MyTask AddTask(string name, string description);

        void DeleteTask(MyTask task);

        void UpdateTask(MyTask task, string description);

        MyTask GetTask(string name);

        List<MyTask> GetAllTasks(); 
    }
}
