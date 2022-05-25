using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopSimpleUI.Models
{
	public static class CartModel
	{
		public static int Id { get; set; }
		public static List<CartItemModel> Products { get; set; }
	}
}
