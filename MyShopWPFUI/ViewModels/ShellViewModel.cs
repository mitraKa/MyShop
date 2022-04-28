﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopWPFUI.ViewModels
{
    public class ShellViewModel : Screen 
    {
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                NotifyOfPropertyChange(() => UserName);
            }
        }

        private string _password;

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


        public void LogIn(string username, string password)
        {
         
            _userName = username;
            _password = password;
            Console.WriteLine("User Logged in");
        }
    }
}
