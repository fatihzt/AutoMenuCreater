﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMenuCreater.Infrastructure.Entity
{
    public interface IEntity<TId>
    {
        TId Id { get; set; }
    }
    public interface IEntity
    {

    }
}
