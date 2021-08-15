using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DbContextModelChange.Entity
{
    public class Table1
    {
        public int Id { get; set; }
    }

    public class Table1Schema1Configuration : IEntityTypeConfiguration<Table1>
    {
        private readonly string _schema;
        public Table1Schema1Configuration(string schema)
        {
            _schema = schema;
        }
        public void Configure(EntityTypeBuilder<Table1> builder)
        {
            builder.ToTable("Table1", _schema);
        }
    }
}
