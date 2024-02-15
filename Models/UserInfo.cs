using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
	public class UserInfo
	{
        public string? Name { get; set; }
        public string? Phone { get; set; }
		
		//Data Notation from string=>email 
		[DataType(DataType.EmailAddress)]
		public string? Email { get; set; }
		public bool? WillAttend { get; set; }
    }
}
