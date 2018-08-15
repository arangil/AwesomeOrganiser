using System;
using System.Collections.Generic;
using System.Linq;
using AwesomeOrganiser.Models;

namespace AwesomeOrganiser.ViewModels
{
    public class HomeViewModel
    {
        public string PageTitle { get; set; }
        public IList<Task> Tasks { get; set;}
    }
}
