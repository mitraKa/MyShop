using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopWPFUI.Library.Models
{
	public sealed class AuthenticatedEmployeeModel
	{
		// todo- This class needs to be a singlelton. need dependency injection

		private static AuthenticatedEmployeeModel _inctance = null;

		public static AuthenticatedEmployeeModel GetInctance()
		{
			if (_inctance == null)
			{
				_inctance = new AuthenticatedEmployeeModel();
			}
			return _inctance;
		}

		private AuthenticatedEmployeeModel()
		{ }
		public string Token { get; set; }
		public  string Id { get; set; }
		public  string FirstName { get; set; }
		public  string LastName { get; set; }
		public  string EmailAddress { get; set; }
		public  string PhoneNumber { get; set; }
		public  DateTime CreatedDate { get; set; }

		
	}
}
