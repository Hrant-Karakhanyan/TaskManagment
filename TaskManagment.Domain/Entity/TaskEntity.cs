using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagment.Domain.Entity
{
    public class TaskEntity
    {
         public Guid Id { get; }
        public string Name { get; set; } 
        public string Description { get; set; }

        public TaskEntity(Guid id, string name, string description)
        {

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Task name cannot be null or empty.", nameof(name));
            }

            Id = id;
            Name = name;
            Description = description;
        }

    }
}
    