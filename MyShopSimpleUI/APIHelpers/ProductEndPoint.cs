using MyShopSimpleUI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MyShopSimpleUI.APIHelpers
{
	public  class ProductEndPoint
	{
		private HttpClient _apiClient;

		public HttpClient ApiClient
		{ 
			get { return _apiClient; }
		}

		public ProductEndPoint()
		{
			InitializeClient();
		}

		private void InitializeClient()
		{
			string api = ConfigurationManager.AppSettings["api"];
			_apiClient = new HttpClient();
			_apiClient.BaseAddress = new Uri(api);
			_apiClient.DefaultRequestHeaders.Accept.Clear();
			_apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
		}

		public async Task<List<CartItemModel>> GetAll( )
		{
			using (HttpResponseMessage response = await ApiClient.GetAsync("/api/Product"))
			{
				if (response.IsSuccessStatusCode)
				{
					var result = await response.Content.ReadAsAsync<List<CartItemModel>>();
					return result;	
				}
				else
				{
					throw new Exception(response.ReasonPhrase);
				}
			}
		}
	}
}
