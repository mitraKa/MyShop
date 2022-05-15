using Caliburn.Micro;
using MyShopWPFUI.Events;
using MyShopWPFUI.Library.APIHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopWPFUI.ViewModels
{
    public class LoginViewModel : Screen
    {
		private string _userName;
		private string _password;
		private IAPIHandler _apiHandler;
		private IEventAggregator _event;


		public LoginViewModel(IAPIHandler apihandler, IEventAggregator eventAggregator)
		{
			_apiHandler = apihandler;
			_event = eventAggregator;
		}

		public string UserName
		{
			get { return _userName; }
			set
			{
				_userName = value;
				NotifyOfPropertyChange(() => UserName);
			}
		}

		public string Password
		{
			get { return _password; }
			set
			{
				_password = value;
				NotifyOfPropertyChange(() => Password);
			}
		}

		

		// TODO - Need to check the Data Entry


		public async Task LogIn(string username, string password)
		{
			_userName = username;
			_password = password;

			try
			{
				var result = await _apiHandler.AuthenticateUser(_userName, _password);
				await _apiHandler.GetLoggedInEmployeeInfo(result.Access_Token);
				await _event.PublishOnUIThreadAsync(new LoginEvent());

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

		}

	}
}
