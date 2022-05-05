using System;

namespace MyShopWPFUI.Library.Models
{
	public interface IAuthenticatedEmployeeModel
	{
		DateTime CreatedDate { get; set; }
		string EmailAddress { get; set; }
		string FirstName { get; set; }
		string Id { get; set; }
		string LastName { get; set; }
		string PhoneNumber { get; set; }
		string Token { get; set; }
	}
}