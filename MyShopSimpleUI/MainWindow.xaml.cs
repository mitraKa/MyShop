
using MyShopSimpleUI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyShopSimpleUI
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private APIHandler _apiHandler = new APIHandler();
		public MainWindow()
		{
			InitializeComponent();
		}

		// TODO - Need to check the Data Entry
		public void ButtonClick(object sender, RoutedEventArgs e)
		{
			var temp =  LogingHelper(User.Text, Pass.Text);
			SalePointView salePointView = new SalePointView();
			var window = new System.Windows.Window();
			window.Content = new SalePointView();
			window.Show();
		}

		public async Task LogingHelper(string username, string password)
		{
			try
			{
				var result = await _apiHandler.AuthenticateUser(username, password);
				await _apiHandler.GetLoggedInEmployeeInfo(result.Access_Token);
				//await _event.PublishOnUIThreadAsync(new LoginEvent());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}


