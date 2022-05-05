
using System.Net.Http;
using System.Threading.Tasks;
using MyShopWPFUI.Library.Models;



namespace MyShopWPFUI.Library.APIHelpers
{
	public interface IAPIHandler
	{

		Task<LoggedInEmployee> AuthenticateUser(string username, string password);

		Task GetLoggedInEmployeeInfo(string token);
	}
}