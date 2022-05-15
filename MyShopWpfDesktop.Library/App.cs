using MvvmCross.ViewModels;
using MyShopWpfDesktop.Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopWpfDesktop.Library
{
	internal class App : MvxApplication
	{
		public override void Initialize()
		{
			RegisterAppStart<DashbordViewModel>();
		}
	}
}
