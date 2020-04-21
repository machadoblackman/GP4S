using System.Collections.Generic;
using System.Threading.Tasks;

namespace GP4S.DataAccessLayer
{
    public interface IDataLayer
    {
        string ConnectionStringName { get; set; }

        Task<List<T>> LoadData<T, U>(string sql, U parameters);
        Task SaveData<T>(string sql, T parameters);
    }
}