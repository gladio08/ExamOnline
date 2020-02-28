using API.Base;
using API.MyConnections;
using API.Repositories.Interfaces;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories
{
    public class GeneralRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity
    {
        private readonly ConnectionString _connectionString;
        public GeneralRepository(ConnectionString connectionString)
        {
            _connectionString = connectionString;
        }
        public async Task<bool> Delete(int id)
        {
            var entity = await _connectionString.Connections.GetAsync<TEntity>(id);
            var delete = await _connectionString.Connections.DeleteAsync(entity);
            return delete;
        }

        public async Task<IEnumerable<TEntity>> Get()
        {
            var getall = await _connectionString.Connections.GetAllAsync<TEntity>();
            return getall;
        }

        public async Task<TEntity> Get(int id)
        {
            var get = await _connectionString.Connections.GetAsync<TEntity>(id);
            return get;
        }

        public async Task<int> Post(TEntity entity)
        {
            var post = await _connectionString.Connections.InsertAsync(entity);
            return post;
        }

        public async Task<bool> Put(TEntity entity)
        {
            var put = await _connectionString.Connections.UpdateAsync(entity);
            return put;
        }
    }
}
