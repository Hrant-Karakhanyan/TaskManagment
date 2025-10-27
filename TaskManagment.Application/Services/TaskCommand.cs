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
        if(Tasks.Count == 0)
        {
                
        }

        return Tasks;
    }

    public ITask GetTask(string name)
    {
        if(!Tasks.Any(t => t.Name == name))
        {
                
        }

        return Tasks.FirstOrDefault(t => t.Name == name)!;
    }
       
}
