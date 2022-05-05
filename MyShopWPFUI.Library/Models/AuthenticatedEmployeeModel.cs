using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopWPFUI.Library.Models
{
	public class AuthenticatedEmployeeModel : IAuthenticatedEmployeeModel
	{
		public string Token { get; set; }
		public string Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string EmailAddress { get; set; }
		public string PhoneNumber { get; set; }
		public DateTime CreatedDate { get; set; }
	}
}
