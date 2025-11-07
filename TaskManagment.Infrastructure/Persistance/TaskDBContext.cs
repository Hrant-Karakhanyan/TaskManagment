using Microsoft.EntityFrameworkCore;
using TaskManagment.Domain.Entity; 

namespace TaskManagment.Infrastructure.Persistence;

public sealed class TaskDbContext : DbContext
{

    public DbSet<TaskEntity> Tasks { get; set; } // Имя таблицы будет "Tasks"

    // 2. Оставляем конструктор для DI
    public TaskDbContext(DbContextOptions<TaskDbContext> options) :
        base(options){ }
}