using System.ComponentModel.DataAnnotations;

namespace _20051350008
{
    public class Volunteer
    {
        public string FullName { get; set; } = "";
        public string Email { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public string Address { get; set; } = "";
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = "";
        public List<string> Skills { get; set; } = new List<string>();
        public string Availability { get; set; } = "";
        public string CommunicationMethod { get; set; } = "";
        public string ProfilePicturePath { get; set; } = "";
    }
}
