using MyShopWPFUI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MyShopWPFUI.Helpers
{
    public class APIHandler : IAPIHandler
	{
		

		public HttpClient ApiClient { get; set; }

		public APIHandler()
		{
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

		public async Task<LoggedInUser> AuthenticateUser(string username, string password)
		{
			var data = new FormUrlEncodedContent(new[]
			{
				new KeyValuePair<string,string>("grant_type","password"),
				new KeyValuePair<string, string>("username", username),
				new KeyValuePair<string, string>("password", password)
			});

			using (HttpResponseMessage response = await ApiClient.PostAsync("/Token", data))
			{
				if (response.IsSuccessStatusCode)
				{
                    var user = await response.Content.ReadAsAsync<LoggedInUser>();
					return user;
				}
				else
				{
					throw new Exception(response.ReasonPhrase);
				}
			}
		}
	}
}
