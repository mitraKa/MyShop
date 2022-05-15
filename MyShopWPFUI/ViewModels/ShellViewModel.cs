using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShopWPFUI.Library.APIHelpers;
using System.Runtime.InteropServices;
using MyShopWPFUI.Events;
using System.Threading;

namespace MyShopWPFUI.ViewModels
{
	public class ShellViewModel : Conductor<object>.Collection.OneActive , IHandle<LoginEvent>
	{
		private IWindowManager _manager;
		private IEventAggregator _event;
		private SalesViewModel _saleModel;

		private LoginViewModel _loginVM;
		public ShellViewModel(LoginViewModel loginVM, IWindowManager manager, IEventAggregator eventAgr)
		{
			_loginVM = loginVM;
			_manager = manager;
			_event = eventAgr;
			_event.SubscribeOnPublishedThread(this);
			_event.SubscribeOnUIThread(this);

		   var res =  testActivate();
		   
		
			_manager.ShowWindowAsync(_loginVM, null, null);
			
		   
		}
		
	

		private async Task testActivate()
		{
			//await this.ActivateItemAsync(_loginVM);
			await ChangeActiveItemAsync(_loginVM, false);
			OnActivationProcessed(_loginVM, true);
		}
		

		public async Task HandleAsync(LoginEvent message, CancellationToken cancellationToken)
		{
			//await ActivateItemAsync(_saleModel);
			await ChangeActiveItemAsync(_loginVM, false);
		}
	}
}
