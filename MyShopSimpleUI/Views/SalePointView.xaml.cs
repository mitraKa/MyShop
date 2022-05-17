using ClassLibrary1.Models;
using MyShopSimpleUI.APIHelpers;
using MyShopSimpleUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace MyShopSimpleUI.Views
{
	/// <summary>
	/// Interaction logic for SalePointView.xaml
	/// </summary>
	public partial class SalePointView : UserControl
	{

		private static SalePointView _instance = null;
		private ProductEndPoint productApi = new ProductEndPoint();
		private BindingList<ProductsModel> _products;
		public SalePointView()
		{
			InitializeComponent();
			//productList.ItemsSource = _products;
		}

		protected override async void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);
			await LoadProductList();
		}

		
		private async Task LoadProductList()
		{
			var prod = await productApi.GetAll();
			_products = new BindingList<ProductsModel>(prod);
			productList.ItemsSource = _products;
		}
		public static SalePointView GetSalePointView()
		{
			if (_instance == null)
			{
				_instance = new SalePointView();
			}
			return _instance;
		}
	}
}
