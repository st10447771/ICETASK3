using System.ComponentModel.DataAnnotations;

namespace CullenInternshipInitiative.Models
{
    public class Companies
    {
        [Key]
        public int companyId { get; set; }
        public required string companyName { get; set; }
        public required string Location { get; set; }
        public required string Industry { get; set; }
        // Fix: Ensure the type CullenInternshipInitiative is correctly referenced.  
        // If CullenInternshipInitiative is a class, ensure it is imported using the correct namespace.
        public required ICollection<Internship> Internships { get; set; }
    }
}
