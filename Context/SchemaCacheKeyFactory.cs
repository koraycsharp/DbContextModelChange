﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DbContextModelReplace.Context
{
    public class SchemaCacheKeyFactory : IModelCacheKeyFactory
    {
        public object Create(DbContext context)
        {
            if (context is ModelChangeContext1 modelChangeContext)
            {
                return new { modelChangeContext.Schema };
            }

            return null;
        }
    }
}
