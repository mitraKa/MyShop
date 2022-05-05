
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MyShopWPFUI;
using MyShopWPFUI.Library.Models;


namespace MyShopWPFUI.Library.APIHelpers
{
    public class APIHandler : IAPIHandler
	{
		public HttpClient ApiClient { get; set; }
		private IAuthenticatedEmployeeModel _authenticatedEmp;

		public APIHandler(IAuthenticatedEmployeeModel authenticatedEmployeeModel)
		{
			_authenticatedEmp = authenticatedEmployeeModel;
			InitializeClient();
		}

		private void InitializeClient()
		{
			string api = ConfigurationManager.AppSettings["api"];
			ApiClient = new HttpClient();
			ApiClient.BaseAddress = new Uri(api);
			ApiClient.DefaultRequestHeaders.Accept.Clear();
			ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
		}

		public async Task<LoggedInEmployee> AuthenticateUser(string username, string password)
		{
			var data = new FormUrlEncodedContent(new[]
			{
				new KeyValuePair<string,string>("grant_type","password"),
				new KeyValuePair<string, string>("username", username),
				new KeyValuePair<string, string>("password", password)
			});

			using (HttpResponseMessage response = await ApiClient.PostAsync("/Token", data))
			{
				//if (response.IsSuccessStatusCode)
				{
                    var user = await response.Content.ReadAsAsync<LoggedInEmployee>();
					return user;
				}
				/*
				else
				{
					throw new Exception(response.ReasonPhrase);
				}
				*/
			}
		}

		public async Task GetLoggedInEmployeeInfo(string token)
		{
			ApiClient.DefaultRequestHeaders.Clear();
			ApiClient.DefaultRequestHeaders.Accept.Clear();
			ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			ApiClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

			using (HttpResponseMessage response = await ApiClient.GetAsync("/api/Employee"))
			{
				if (response.IsSuccessStatusCode)
				{
					var result = await response.Content.ReadAsAsync<AuthenticatedEmployeeModel>();
					_authenticatedEmp.Id = result.Id;
					_authenticatedEmp.FirstName = result.FirstName;
					_authenticatedEmp.LastName = result.LastName;
					_authenticatedEmp.PhoneNumber = result.PhoneNumber;
					_authenticatedEmp.EmailAddress = result.EmailAddress;
					_authenticatedEmp.CreatedDate = result.CreatedDate;
					_authenticatedEmp.Token = token;
				}
				else
				{
					throw new Exception(response.ReasonPhrase);
				}
			}
		}
		/*
		// TODO - Get Rid of this
		Task<LoggedInEmployee> IAPIHandler.AuthenticateUser(string username, string password)
		{
			throw new NotImplementedException();
		}

	*/


		// TODO - get rid if this

	}
}
