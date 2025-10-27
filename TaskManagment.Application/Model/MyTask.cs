using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagment.Domain.Interfaces;
namespace TaskManagment.Application.Model
{
    public class MyTask : ITask
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public MyTask() { }  
        
        public MyTask(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
