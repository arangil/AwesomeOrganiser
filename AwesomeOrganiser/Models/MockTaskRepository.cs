using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeOrganiser.Models
{
    public class MockTaskRepository : ITaskRepository
    {
        private List<Task> _tasks;

        public MockTaskRepository()
        {
            if (_tasks == null)
            {
                InitializeTasks();
            }
        }

        private void InitializeTasks()
        {
            _tasks = new List<Task>
                {
                    new Task {TaskId = 1, TaskTitle = "Apple", TaskDescription="Buy Apples", TaskDueDate=Convert.ToDateTime("11/1/2018"), IsComplete=false,TaskComments="Need to buy apples"},
                    new Task {TaskId = 1, TaskTitle = "Bananas", TaskDescription="Buy Bananas", TaskDueDate=Convert.ToDateTime("11/12/2018"), IsComplete=false,TaskComments="Need to buy Bananas"},
                    new Task {TaskId = 1, TaskTitle = "Cereal", TaskDescription="Buy Cereal", TaskDueDate=Convert.ToDateTime("11/13/2018"), IsComplete=false,TaskComments="Need to buy Cereal"},
                    new Task {TaskId = 1, TaskTitle = "Milk", TaskDescription="Buy Milk", TaskDueDate=Convert.ToDateTime("11/14/2018"), IsComplete=false,TaskComments="Need to buy Milk"}
                };
        }

        public IEnumerable<Task> GetAllTasks()
        {
            return _tasks;
        }

        public Task GetTaskById(int taskId)
        {
            return _tasks.FirstOrDefault(t => t.TaskId == taskId);
        }

        public void AddTask(Task task)
        {
            throw new NotImplementedException();
        }
    }
}
