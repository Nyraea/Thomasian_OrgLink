namespace ThomasianOrglist.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Organization> Organizations { get; set; }
    }
}
