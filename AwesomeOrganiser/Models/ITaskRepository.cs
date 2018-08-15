using System;
using System.Collections.Generic;

namespace AwesomeOrganiser.Models
{
    public interface ITaskRepository
    {
        IEnumerable<Task> GetAllTasks();
        Task GetTaskById(int taskId);
        void AddTask(Task task);
    }
}
