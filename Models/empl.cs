using System.ComponentModel.DataAnnotations;

namespace Hrpage.Models
{
	public class empl
	{
        //name
        [Required]
		[StringLength(20,MinimumLength=3 ,ErrorMessage ="Invalid Name")]
        public string Name { get; set; }
		//depart
		[Required]
		[DataType(DataType.Date)]
		public string depart { get; set; }
		//is active
		[Required]
		public bool isactive { get; set; }
		[Required]
		public DateTime birthdate { get; set; }

		[Required(ErrorMessage = "please enter your Email")]
		[DataType(DataType.EmailAddress)]
		public string email { get; set; }

    }
}
