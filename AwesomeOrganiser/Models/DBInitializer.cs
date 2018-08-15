using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeOrganiser.Models
{
    public static class DBInitializer
    {
        public  static void Seed(AppDbContext context)
        {
            if (!context.Tasks.Any())
            {
                context.AddRange(
                     new Task { TaskTitle = "Pineaple", TaskDescription = "Buy Pineaple", TaskDueDate = Convert.ToDateTime("11/1/2018"), IsComplete = false, TaskComments = "Need to buy Pineaple" },
                    new Task { TaskTitle = "Bananas", TaskDescription = "Buy Bananas", TaskDueDate = Convert.ToDateTime("11/12/2018"), IsComplete = false, TaskComments = "Need to buy Bananas" },
                    new Task { TaskTitle = "Cereal", TaskDescription = "Buy Cereal", TaskDueDate = Convert.ToDateTime("11/13/2018"), IsComplete = false, TaskComments = "Need to buy Cereal" },
                    new Task { TaskTitle = "Milk", TaskDescription = "Buy Milk", TaskDueDate = Convert.ToDateTime("11/14/2018"), IsComplete = false, TaskComments = "Need to buy Milk" }
                    );
                context.SaveChanges();
            }
        }
    }
}
