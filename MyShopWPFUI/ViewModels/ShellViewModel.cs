using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShopWPFUI.Library.APIHelpers;


namespace MyShopWPFUI.ViewModels
{
    public class ShellViewModel : Screen 
    {
        private string _userName;
		private string _password;
		private IAPIHandler _apiHandler;


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

		public ShellViewModel(IAPIHandler apihandler)
		{
			_apiHandler = apihandler;
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

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);

			}
            
        }
    }
}
