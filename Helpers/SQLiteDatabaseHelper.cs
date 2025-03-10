using Minhas_Compras.Models;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Minhas_Compras.Helpers
{
    public class SQLiteDatabaseHelper
    {
        readonly SQLiteAsyncConnection _conn;

        public SQLiteDatabaseHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
        }

        public async Task InitializeAsync()
        {
            await _conn.CreateTableAsync<Produto>();
        }

        public Task<int> Insert(Produto p)
        {
            return _conn.InsertAsync(p);
        }

        public Task<int> Update(Produto p)
        {
            return _conn.UpdateAsync(p);
        }

        public Task<int> Delete(int id)
        {
            return _conn.DeleteAsync<Produto>(id);
        }

        public Task<List<Produto>> GetAll()
        {
            return _conn.Table<Produto>().ToListAsync();
        }

        public Task<List<Produto>> Search(string q)
        {
            string sql = "SELECT * FROM Produto WHERE Descricao LIKE ?";
            return _conn.QueryAsync<Produto>(sql, "%" + q + "%");
        }
    }
}
