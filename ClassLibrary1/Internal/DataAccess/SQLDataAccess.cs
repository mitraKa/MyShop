using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopDataManager.Library.Internal.DataAccess
{
	internal class SQLDataAccess
	{
		private string GetConnectionString(string name)
		{
			return ConfigurationManager.ConnectionStrings[name].ConnectionString;
		}

		public List<T> GetDataFromDatabase<T, U>(string storeProcedure, U parameter, string connectionstring)
		{
			string connectionString = GetConnectionString(connectionstring);
			using (IDbConnection cnn = new SqlConnection(connectionString))
			{
				List<T> rows = cnn.Query<T>(storeProcedure, parameter, commandType: CommandType.StoredProcedure).ToList();
				return rows;
            }
		}
	}
}
