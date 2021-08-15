using System;
using DbContextModelChange.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DbContextModelChange.Context
{
    public class ModelChangeContext1 : DbContext
    {
        public string Schema { get; set; } = "Schema1";

        private readonly ILoggerFactory _loggerFactory;

        public DbSet<Table1> Table1 { get; set; }

        //runtime
        public ModelChangeContext1(IServiceProvider serviceProvider)
        {
            _loggerFactory = serviceProvider.GetService<ILoggerFactory>();
        }

        //design-time
        public ModelChangeContext1(string schema)
        {
            Schema = schema;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new Table1Schema1Configuration(Schema));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,7010; Database=ModelChangeDb; User Id=sa; Password=qwe123**; Connection Timeout=10");

            if (_loggerFactory != null)
            {
                optionsBuilder.UseLoggerFactory(_loggerFactory);
            }

            optionsBuilder.ReplaceService<IModelCacheKeyFactory, SchemaCacheKeyFactory>();
        }
    }

    public class ModelChangeContext2 : ModelChangeContext1
    {
        public ModelChangeContext2(string schema) : base(schema)
        {
            Schema = schema;
        }
    }

}
