﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sf.Budget.Core.Domain.Abstractions
{
    public abstract class DomainEntity : IDomainEntity
    {
        public int Id { get; protected set; }
       
    }
}
