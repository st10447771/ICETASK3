using System.ComponentModel.DataAnnotations;

namespace CullenInternshipInitiative.Models
{
    public class Students
    {
        [Key]
        public int studentId { get; set; }
        public required string firstName { get; set; }
        public required string lastName { get; set; }
        public required string Email { get; set; }
        public int YearLevel { get; set; }

        public required ICollection<Internship> Internships { get; set; }
    }
}
