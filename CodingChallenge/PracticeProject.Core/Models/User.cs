using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PracticeProject.Core.Models
{
    public class User
    {
        public User()
        {
            Projects = new Collection<Project>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}