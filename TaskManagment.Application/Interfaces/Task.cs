using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagment.Application.Interfaces
{
    public interface Task
    {
        string Name { get; }
        string Description { get; set; }
    }
}
