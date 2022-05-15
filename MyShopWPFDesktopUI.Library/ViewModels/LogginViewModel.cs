using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopWPFDesktopUI.Library.ViewModels
{
	public class LogginViewModel : MvxViewModel
	{
		private string  _userName;
		private string _password;

		public string  Username
		{
			get { return _userName; }
			set { SetProperty(ref _userName, value); }
		}

		public string Password
		{
			get { return _password; }
			set { SetProperty(ref _password, value); }
		}

		public async Task LogIn(string username, string password)
		{
			_userName = username;
			_password = password;

			try
			{

				//var result = await _apiHandler.AuthenticateUser(_userName, _password);
				//await _apiHandler.GetLoggedInEmployeeInfo(result.Access_Token);
				//await _event.PublishOnUIThreadAsync(new LoginEvent());

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

		}


	}
}
