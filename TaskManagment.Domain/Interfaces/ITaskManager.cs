namespace TaskManagment.Domain.Interfaces;

public interface ITaskManager 
{
    ITask AddTask(string name, string description);

    void DeleteTask(ITask task);

    void UpdateTask(ITask task, string description);

    ITask GetTask(string name);

    List<ITask> GetAllTasks(); 
}
