﻿using System;
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

        public TaskEntity(string name, string description) 
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
        }
        
        private TaskEntity() {}
    }
}