using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopWPFUI.ViewModels
{
	class SalesViewModel : Screen
	{
		private BindingList<string> _productList;
		public BindingList<string> ProductList
		{
			get { return _productList; }
			set { _productList = value;
				NotifyOfPropertyChange(() => ProductList);
			}
		}

		private string _quantity;
		public string Quantity
		{
			get { return _quantity; }
			set { _quantity = value;
				NotifyOfPropertyChange(() => Quantity);
			}
		}

		private bool CanAddProduct()
		{
			// check if a product is selected
			throw new NotImplementedException();
		}
		public void AddProduct()
		{

		}

		private bool CanRemoveProduct()
		{
			throw new NotImplementedException();
		}

		public void RemoveProduct()
		{

		}

		private BindingList<string> _Cart;
		public BindingList<string> Cart
		{
			get { return _Cart; }
			set { _Cart = value;
				NotifyOfPropertyChange(() => Cart);
			}
		}

		private string _subTotal;
		public  string SubTotal
		{
			get { return _subTotal; }
		}

		private string _tax;
		public string Tax
		{
			get { return _subTotal; }
		}

		private string _total;
		public string Total
		{
			get { return _subTotal; }
		}


		private bool CanCheckOut()
		{
			throw new NotImplementedException();
		}
		public void CheckOut()
		{
		}
	}
}
