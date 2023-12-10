namespace ThomasianOrglist.Models
{
    public class Department
    {
        // Use DepartmentName enum values as the DepartmentId
        public DepartmentName Id { get; set; }
        public string Name { get; set; }

        // Navigation property for the one-to-many relationship
        public ICollection<Organization> Organizations { get; set; }
    }
}
