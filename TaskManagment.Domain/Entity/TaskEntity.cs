using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagment.Domain.Entity
{
    public interface TaskEntity
    {
         Guid Id { get; }
        string Name { get; set; }
        string Description { get; set; }
    }
}
    