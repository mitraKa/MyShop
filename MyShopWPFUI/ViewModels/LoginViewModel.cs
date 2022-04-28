using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopWPFUI.ViewModels
{
    class LoginViewModel : Screen
    {
        private string _userName;

        public string username
        {
            get { return _userName; }
            set {
                _userName = value;
                NotifyOfPropertyChange(() => username);
                }
        }

        private string _password;

        public string password
        {
            get { return _password; }
            set
            {
                _password = value;
                NotifyOfPropertyChange(() => password);
            }
        }

        public void LogIn(string username, string password)
        {
            _userName = username;
            _password = password;
            Console.WriteLine("we just clicked");

        }

    }
}
