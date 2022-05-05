using ClassLibrary1.DataAccess;
using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;

namespace MyShopDataManager.Controllers
{
	[Authorize]


	public class EmployeeController : ApiController
    {
        // GET: api/Employee/5
		[HttpGet]
        public EmployeeModel GetEmployeeById()
        {
			EmployeeDataAccess EmpDataAcc = new EmployeeDataAccess();
			EmployeeModel emp = new EmployeeModel();

			String ID = RequestContext.Principal.Identity.GetUserId();
			emp = EmpDataAcc.GetEmployeeById(ID);
			return emp;
        }
    }
}
