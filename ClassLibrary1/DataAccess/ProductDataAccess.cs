using ClassLibrary1.Models;
using MyShopDataManager.Library.Internal.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.DataAccess
{
	public class ProductDataAccess
	{
		public List<ProductModel> GetProduct()
		{
			SQLDataAccess sql = new SQLDataAccess();

			List<ProductModel> prodList = sql.GetDataFromDatabase<ProductModel, dynamic>("SpProduct", new { }, "MyShopDatabase");
			return prodList;
		}
	}
}
