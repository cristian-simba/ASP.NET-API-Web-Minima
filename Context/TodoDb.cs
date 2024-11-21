using ApiWebMinima.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiWebMinima.Context
{
    public class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options): base (options) 
        {
            
        }
        public DbSet<Todo> Todos => Set<Todo>();
    }
}
