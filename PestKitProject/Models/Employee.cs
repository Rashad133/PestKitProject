namespace PestKitProject.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public string X {  get; set; }
        public string Facebook {  get; set; }
        public string Instagram { get; set; }
        public string Linkedin { get; set; }
        public string Image {  get; set; }

    }
}
