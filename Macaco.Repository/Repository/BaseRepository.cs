using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using Dapper;
using Macaco.Infraestructure.Domain;
using Macaco.Repository.Extensions;
using Macaco.Repository.Interface.IRepository;
using MySql.Data.MySqlClient;

namespace Macaco.Repository.Repository
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : EntityBase, IAggregateRoot
    {
        private readonly string _tableName;

        public IDbConnection Connection
        {
            get
            {
                return new MySqlConnection(ConfigurationManager.ConnectionStrings["MysqlConnection"].ConnectionString);
            }
        }

        public BaseRepository(string tableName)
        {
            _tableName = tableName;
        }

        internal virtual dynamic Mapping(T item)
        {
            return item;
        }

        public virtual void Add(T item)
        {
            using (IDbConnection cn = Connection)
            {
                var parameters = (object)Mapping(item);
                cn.Open();
                item.Id = cn.Insert<int>(_tableName, parameters, item.Key);
            }
        }

        public virtual void Update(T item)
        {
            using (IDbConnection cn = Connection)
            {
                var parameters = (object)Mapping(item);
                cn.Open();
                cn.Update(_tableName, parameters);
            }
        }

        public virtual void Remove(T item)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                cn.Execute(string.Format("DELETE FROM " + _tableName + " WHERE {0}=@Id", item.Key), new { Id = item.Id });
            }
        }

        public virtual T FindById(int id)
        {
            T item = default(T);

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                item = cn.Query<T>("SELECT * FROM " + _tableName + " WHERE Id=@Id", new { Id = id }).SingleOrDefault();
            }

            return item;
        }

        public IEnumerable<T> Find(dynamic param)
        {
            return Find(DynamicQuery.GetWhereQuery(param), param);
        }

        public virtual IEnumerable<T> Find(string query, dynamic param)
        {
            IEnumerable<T> items = null;

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                items = cn.Query<T>("SELECT * FROM " + _tableName + " WHERE " + query, (object)param);
            }

            return items;
        }

        public virtual IEnumerable<T> FindAll()
        {
            IEnumerable<T> items = null;

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                items = cn.Query<T>("SELECT * FROM " + _tableName);
            }

            return items;
        }



    }
}
