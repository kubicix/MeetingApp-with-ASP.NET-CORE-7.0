using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
	public class UserInfo
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Name is required")]
		public string? Name { get; set; }
		[Required]
		[RegularExpression(@"^[0-9]*$", ErrorMessage = "Phone must be numeric")]
		public string? Phone { get; set; }
		[Required]
		[DataType(DataType.EmailAddress, ErrorMessage = "Invalid email format")]
		public string? Email { get; set; }

		[Required(ErrorMessage = "Please specify attendance")]
		public bool? WillAttend { get; set; }
	}
}
