namespace RoutingDIExample.Services
{
    public class StudentService : IStudentService
    {
        public object GetStudentDetails(int id)
        {
            if (id == 101)
                return new { Id = 101, Name = "Rahul Sharma", Course = "BCA" };

            if (id == 102)
                return new { Id = 102, Name = "Priya Patil", Course = "BCA" };

            if (id == 103)
                return new { Id = 103, Name = "Amit Joshi", Course = "BCA" };

            return new { Message = "Student not found" };
        }

        public string GetStudentName(int id)
        {
            if (id == 101)
                return "Rahul Sharma";

            if (id == 102)
                return "Priya Patil";

            if (id == 103)
                return "Amit Joshi";

            return "Student not found";
        }
    }
}