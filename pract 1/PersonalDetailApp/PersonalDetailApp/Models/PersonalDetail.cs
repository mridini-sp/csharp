namespace PersonalDetailsApp.Models
{
    public class PersonalDetails
    {
        public string Name { get; set; } = "";
        public string Contact { get; set; } = "";
        public string Location { get; set; } = "";
        public string Gender { get; set; } = "";

        public List<string> Education { get; set; } = new();
    }
}