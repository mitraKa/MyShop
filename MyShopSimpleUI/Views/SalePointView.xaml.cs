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
		private BindingList<Models.CartItemModel> _products;
		private BindingList<CartItemModel> _carts;
		
		
		private Models.CartItemModel selectedProduct;
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
			_products = new BindingList<Models.CartItemModel>(prod);
			productList.ItemsSource = _products;
			_carts = new BindingList<Models.CartItemModel>();
			//Cart.ItemsSource = _carts;
			//Cart.ItemsSource = _carts;
		}
		public static SalePointView GetSalePointView()
		{
			if (_instance == null)
			{
				_instance = new SalePointView();
			}
			return _instance;
		}

		private bool CanAddToTheCard()
		{
			selectedProduct = productList.SelectedItem as Models.CartItemModel;
			selectedProduct.QuantityInTheCart = Quantity.Text;
			if (Int32.Parse(Quantity.Text) > 0 && selectedProduct.Quantity > Int32.Parse(Quantity.Text))
			{
				return true;
			}
			return false;
		}

		private void AddProduct_Click(object sender, RoutedEventArgs e)
		{
			CartItemModel cartItem = _carts.FirstOrDefault(x => x.ProductName == selectedProduct.ProductName);
			if (CanAddToTheCard())
			{		
				selectedProduct = productList.SelectedItem as CartItemModel;
				
				//if ( cartItem != null)
				//{
				//	selectedProduct.QuantityInTheCart = Quantity.Text + selectedProduct.QuantityInTheCart;
				//}
				//else 
				{
					Cart.Items.Add(selectedProduct);
					//_carts.Add(selectedProduct);		
				}
			}
		}


	}
}
