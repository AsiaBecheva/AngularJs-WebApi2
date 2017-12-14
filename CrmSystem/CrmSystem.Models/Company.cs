using System;
using System.Collections.Generic;

namespace CrmSystem.Models
{
    public class Company
    {

        private ICollection<Project> projects;
        public Company()
        {
            this.AddedOn = DateTime.Now;
            this.projects = new HashSet<Project>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Info { get; set; }

        public DateTime AddedOn { get; set; }

        public virtual ICollection<Project> Projects
        {
            get { return this.projects; }
            set { this.projects = value; }
        }
    }
}
