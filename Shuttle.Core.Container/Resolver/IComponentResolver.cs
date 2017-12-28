﻿using System;
using System.Collections.Generic;

namespace Shuttle.Core.Container
{
    public interface IComponentResolver
    {
        object Resolve(Type dependencyType);
        IEnumerable<object> ResolveAll(Type dependencyType);
    }
}