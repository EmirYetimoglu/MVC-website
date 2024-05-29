using System.Collections.Generic;
using _20051350008.Models;

public class VolunteerModel
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; }
    public List<string> Skills { get; set; }
    public string Availability { get; set; }
    public string CommunicationMethod { get; set; }
    public string ProfilePicturePath { get; set; }
}

public static class VolunteerData
{
    public static List<VolunteerModel> GetList()
    {
        List<VolunteerModel> volunteers = new List<VolunteerModel>
        {
             new VolunteerModel
            {
                FullName = "Rahul Kumar",
                Email = "rahul@example.com",
                PhoneNumber = "123456789",
                Address = "123 Main Street",
                DateOfBirth = new DateTime(1990, 5, 15),
                Gender = "Male",
                Skills = new List<string> { "Programming", "Marketing" },
                Availability = "Full-time",
                CommunicationMethod = "Email",
                ProfilePicturePath = "/images/profiles/rahul.jpg"
            },
            new VolunteerModel
            {
                FullName = "Jose Mathews",
                Email = "jose@example.com",
                PhoneNumber = "987654321",
                Address = "456 Oak Avenue",
                DateOfBirth = new DateTime(1985, 10, 25),
                Gender = "Male",
                Skills = new List<string> { "Fundraising" },
                Availability = "Part-time",
                CommunicationMethod = "Phone",
                ProfilePicturePath = "/images/profiles/jose.jpg"
            }
        };
        return volunteers;
    }

    public static VolunteerModel Get(int Id1)
    {
        List<VolunteerModel> volunteers = GetList();
        foreach (VolunteerModel volunteer in volunteers)
        {
           Console.WriteLine($"Name: {volunteer.FullName}");
            Console.WriteLine($"Email: {volunteer.Email}");
            Console.WriteLine($"Phone Number: {volunteer.PhoneNumber}");
            Console.WriteLine($"Address: {volunteer.Address}");
            Console.WriteLine($"Date of Birth: {volunteer.DateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Gender: {volunteer.Gender}");
            Console.WriteLine($"Skills: {string.Join(", ", volunteer.Skills)}");
            Console.WriteLine($"Availability: {volunteer.Availability}");
            Console.WriteLine($"Communication Method: {volunteer.CommunicationMethod}");
            Console.WriteLine($"Profile Picture Path: {volunteer.ProfilePicturePath}");
            Console.WriteLine();
        }
        return null;
    }
}
