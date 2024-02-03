using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Models
{
    public class Jobs
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Company { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Position { get; set; }

        [Required]
        [Display(Name = "Date Posted")]
        [DataType(DataType.Date)]
        public DateTime? DatePosted { get; set; }
        [Required]
        public string? Location { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public int? Salary { get; set; }    
    }
}
