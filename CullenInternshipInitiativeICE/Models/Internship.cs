using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CullenInternshipInitiative.Models
{
    public class Internship
    {
        [Key]
        public int InternshipId { get; set; }
        public required string positionTitle { get; set; }
        public required string description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int studentId { get; set; }
        public int companyId { get; set; }
        // Navigation properties
        [ForeignKey("studentId")]
        public required Students Student { get; set; } = null!; // Use null-forgiving operator to indicate that this property will be set later
        [ForeignKey("companyId")]
        public Companies Company { get; set; } = null!; // Use null-forgiving operator to indicate that this property will be set later
    }
}
