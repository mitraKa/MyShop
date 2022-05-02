using System.Net.Http;
using System.Threading.Tasks;
using MyShopWPFUI.Models;

namespace MyShopWPFUI.Helpers
{
	public interface IAPIHandler
	{
		HttpClient ApiClient { get; set; }

		Task<LoggedInUser> AuthenticateUser(string username, string password);
	}
}