namespace CrmSystem.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Company Company { get; set; }
    }
}
