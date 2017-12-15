using CrmSystem.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrmSystem.Server.Models
{
    public class CustomerBindingModel
    {
        [Required]
        public string Name { get; set; }

        public int Phone { get; set; }

        [Required]
        public string Email { get; set; }

        public string Info { get; set; }

        public List<Project> Projects { get; set; }
    }
}