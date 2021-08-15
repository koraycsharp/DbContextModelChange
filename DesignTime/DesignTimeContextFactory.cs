using DbContextModelChange.Context;
using Microsoft.EntityFrameworkCore.Design;

namespace DbContextModelReplace.DesignTime
{
    public class DataContextDesignFactory1 : IDesignTimeDbContextFactory<ModelChangeContext1>
    {
        public ModelChangeContext1 CreateDbContext(string[] args)
        {
            return new ModelChangeContext1("Schema1");
        }
    }

    public class DataContextDesignFactory2 : IDesignTimeDbContextFactory<ModelChangeContext2>
    {
        public ModelChangeContext2 CreateDbContext(string[] args)
        {
            return new ModelChangeContext2("Schema2");
        }
    }
}
