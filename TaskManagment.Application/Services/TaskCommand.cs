using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagment.Application.Interfaces;
using TaskManagment.Application.Model;

namespace TaskManagment.Application.Services
{
    public class TaskCommand : ITaskManager
    {
        private readonly List<MyTask> _tasks = new List<MyTask>();

        public MyTask AddTask(string name, string description)
        {
            
            var newTask = new MyTask(name, description);

            
            _tasks.Add(newTask);

            System.Console.WriteLine($"[Логика]: Задача '{name}' добавлена.");

            return newTask;
        }

        public void DeleteTask(MyTask task)
        {
            
            _tasks.Remove(task);

            System.Console.WriteLine($"[Логика]: Задача '{task.Name}' удалена.");
        }

        public void UpdateTask(MyTask task, string description)
        {
            var existingTask = _tasks.FirstOrDefault(t => t.Name == task.Name);
            if (existingTask != null)
            {
                existingTask.Description = description;
                System.Console.WriteLine($"[Логика]: Задача '{task.Name}' обновлена.");
            }
        }

        public List<MyTask> GetAllTasks()
        {
            if(_tasks.Count == 0)
            {
                System.Console.WriteLine("[Логика]: Список задач пуст.");
            }

            return _tasks;
        }

        public MyTask GetTask(string name)
        {
            if(!_tasks.Any(t => t.Name == name))
            {
                System.Console.WriteLine($"[Логика]: Задача с именем '{name}' не найдена.");
            }

            return _tasks.FirstOrDefault(t => t.Name == name);
        }
       
    }
}
