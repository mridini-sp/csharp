namespace RoutingDIExample.Services
{
    public interface IStudentService
    {
        object GetStudentDetails(int id);
        string GetStudentName(int id);
    }
}