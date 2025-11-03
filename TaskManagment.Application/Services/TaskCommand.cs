using System.Xml.Linq;
using TaskManagment.Application.Model;
using TaskManagment.Domain.Interfaces;

namespace TaskManagment.Application.Services;

public class TaskCommand() : ITaskManager
{
    private readonly List<ITask> Tasks = [];

    public ITask AddTask(string name, string description)
    {
            
        MyTask newTask = new(name, description);
        Tasks.Add(newTask);

           

        return newTask;
    }

    public void DeleteTask(ITask task)
    {

        Tasks.Remove(task);

            
    }

    public void UpdateTask(ITask task, string description)
    {
        ITask? existingTask = Tasks.FirstOrDefault(t => t.Name == task.Name);
        if (existingTask == null) return;
        existingTask.Description = description;
        
    }

    public List<ITask> GetAllTasks()
    {
        
        return Tasks.ToList();
    }

    public ITask GetTask(string name)
    {
        ITask? foundTask = Tasks.FirstOrDefault(t => t.Name == name);

        if (foundTask == null)
        {
            // Throw a specific exception
            throw new KeyNotFoundException($"Task with name '{name}' not found.");
        }

        return foundTask;
    }

}
