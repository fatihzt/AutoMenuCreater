using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMenuCreater.Infrastructure.Entity
{
    public abstract class Entity : Entity<int>
    {

    }

    public abstract class Entity<TId> : IEntity<TId>
    {
        public TId Id { get; set; }

        public override int GetHashCode()
        {
            if (Equals(Id, default(TId)))
                return base.GetHashCode();
            return Id.GetHashCode();
        }
    }
}
