using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
	public class EmployeeModel
	{
		public string Id { get; set; }
		public string FirstNmae { get; set; }
		public string LastName { get; set; }
		public string EmailAddress { get; set; }
		public string PhoneNumber { get; set; }
		public DateTime CreatedDate { get; set; }
	}
}
