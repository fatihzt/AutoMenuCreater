using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMenuCreater.Infrastructure.Data.Abstractions
{
    public interface IStorage
    {
        /// <summary>
        /// Gets the underlying storage context used by this storage.
        /// </summary>
        IStorageContext StorageContext { get; }

        /// <summary>
        /// Gets a repository of the given type.
        /// </summary>
        /// <typeparam name="T">The type parameter to find implementation of.</typeparam>
        /// <returns></returns>
        T GetRepository<T>() where T : IMustHaveSetStorageContext;

        /// <summary>
        /// Commits the changes made by all the repositories.
        /// </summary>
        void Save();

        /// <summary>
        /// Asynchronously commits the changes made by all the repositories.
        /// </summary>
        Task SaveAsync();

    }

}
