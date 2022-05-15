using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopWPFDesktopUI.Library.ViewModels
{
	public class App :MvxApplication
	{
		public override void Initialize()
		{
			RegisterAppStart<DashboardViewModel>();
		}
	}
}
