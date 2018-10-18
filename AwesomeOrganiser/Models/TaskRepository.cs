using System;
using System.Collections.Generic;
using System.Linq;


namespace AwesomeOrganiser.Models
{
    public class TaskRepository:ITaskRepository
    {
        //Added reference to AppDbContext
        private readonly AppDbContext _appDbContext;

        //Constructer inject appdbcontext
        public TaskRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddTask(Task task)
        {
            task.ModifiedDate = DateTime.Now;
            _appDbContext.Tasks.Add(task);
            _appDbContext.SaveChanges();
        }

        public void UpdateTask(Task task)
        {
            task.ModifiedDate = DateTime.Now;
            _appDbContext.Tasks.Update(task);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Task> GetAllTasks()
        {
            return _appDbContext.Tasks;
        }

        public Task GetTaskById(int taskId)
        {
            return _appDbContext.Tasks.FirstOrDefault(t => t.TaskId == taskId);
        }
    }
}
