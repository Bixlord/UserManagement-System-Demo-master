using ComponentModel.DataAnnotations;

namespace UserManagement_System_Demo.Models
{
	public class support : Base
	{
		public string subject { get; set; }

        [Required]
        [StringLenght(MinimumLenght = 5, MaximumLenght = 30,
        ErrorMessage = "{0} cannot be less than 5 and {1} cannot be greater than 30")]
        public string Content { get; set; }

        [Required]
        public bool? Istreated { get; set; }

        [Required]
        public string status { get; set; }

        [Required]
        [Display(Name = "Sent By")]
        public int SentById { get; set; }

        
    }
}
