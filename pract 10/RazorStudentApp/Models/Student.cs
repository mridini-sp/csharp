namespace RazorStudentApp.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string email { get; set; }= string.Empty;
        public string Course { get; set;  }=string.Empty;
    }
}
