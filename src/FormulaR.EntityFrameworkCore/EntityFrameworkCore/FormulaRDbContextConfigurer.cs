using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace FormulaR.EntityFrameworkCore
{
    public static class FormulaRDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<FormulaRDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<FormulaRDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
