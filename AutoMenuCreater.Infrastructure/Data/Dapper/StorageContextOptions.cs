using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMenuCreater.Infrastructure.Data.Dapper
{
    public class StorageContextOptions
    {
        /// <summary>
        /// The connection string that is used to connect to the physical storage.
        /// </summary>
        public string ConnectionString { get; set; }
    }
}
