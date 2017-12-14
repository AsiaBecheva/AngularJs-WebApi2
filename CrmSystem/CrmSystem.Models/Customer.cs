using System;
using System.Collections.Generic;

namespace CrmSystem.Models
{
    public class Customer
    {
        private ICollection<Project> projects;

        public Customer()
        {
            this.AddedOn = DateTime.Now;
            this.projects = new HashSet<Project>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Phone { get; set; }

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
