using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagment.Domain.Interfaces
{
    public interface ITask 
    {
        string Name { get; set; }
        string Description { get; set; }
    }
}
