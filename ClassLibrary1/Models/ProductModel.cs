using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
	public class ProductModel
	{
		public int Id { get; set; }
		public string ProductName { get; set; }
		public string ProductDescription { get; set; }
		public string Quantity { get; set; }
		public string SalePrice { get; set; }
	}
}
