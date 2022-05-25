using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopSimpleUI.Models
{
	public class CartItemModel
	{
		public int Id { get; set; }
		public string ProductName { get; set; }
		public string ProductDescription { get; set; }


		public int Quantity;

		public string SalePrice { get; set; }

		private string QuantityInCart;

		public string QuantityInTheCart
		{
			get { return QuantityInCart; }
			set { QuantityInCart = value; } 
		}

		public bool Taxable;
		public string DisplayProduct
		{
			get {
				String data = String.Format("{0,-35} {1,-20} {2,-10} \n",
 ProductName, $"${SalePrice}", QuantityInCart);
				return data;
			    }
		}

		private decimal TotalPrice;

		public decimal MyTotalPrice
		{
			get { return decimal.Parse(SalePrice) * Int32.Parse(QuantityInCart); }
		}

	}
}
