using ClassLibrary1.Models;
using MyShopDataManager.Library.Internal.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.DataAccess
{
	public class EmployeeDataAccess
	{
		public EmployeeModel GetEmployeeById(string id)
		{
			SQLDataAccess sql = new SQLDataAccess();

			var p = new { id = id };
			List<EmployeeModel> empList = sql.GetDataFromDatabase<EmployeeModel , dynamic>("SpEmployeeFind", p , "MyShopDatabase");

			return empList.First();
		}
	}
}
