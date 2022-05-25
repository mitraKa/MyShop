using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopSimpleUI.Models
{
	public class PoductsModel
	{
		public int Id { get; set; }
		public string ProductName { get; set; }
		public string ProductDescription { get; set; }
		public int Quantity { get; set; }
		public string SalePrice { get; set; }

		public bool Taxable;
	}
}
