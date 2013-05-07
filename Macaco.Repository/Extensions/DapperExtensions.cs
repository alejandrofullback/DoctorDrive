using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;

namespace Macaco.Repository.Extensions
{
    public static class DapperExtensions
    {
        public static T Insert<T>(this IDbConnection cnn, string tableName, dynamic param, string key)
        {
	        var insertQuery = DynamicQuery.GetInsertQuery(tableName, param, key);
            IEnumerable<T> result = SqlMapper.Query<T>(cnn, insertQuery, param);
            return result.First();
        }

        public static void Update(this IDbConnection cnn, string tableName, dynamic param)
        {
            SqlMapper.Execute(cnn, DynamicQuery.GetUpdateQuery(tableName, param), param);
        }
    }
}
