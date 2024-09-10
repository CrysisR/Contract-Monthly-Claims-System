using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROG6212POE.Models
{
    public class Claims
    {
        //columns if you want the claims table
        [Key]
        public int Id { get; set; }
        public string LecturerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public DateTime ClaimsPeriodStart { get; set; }
        [Required]
        public DateTime ClaimsPeriodEnd { get; set; }
        [Required]
        public double HoursWorked { get; set; }
        [Required]
        public double RatePerHour { get; set; }
        [Required]
        public double TotalAmount { get; set; }
        public string DescriptionOfWork { get; set; }

        [NotMapped]
        public List<IFormFile> SupportingDocuments { get; set; }
    }
}
