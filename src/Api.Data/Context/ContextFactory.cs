using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //Usado para Criar as Migrações

            var connectionString = "Server=localhost;Port=3306;Database=dbAPI;Uid=mauro;Pwd=123456";

            //var connectionString = "Server=192.168.129.20;User ID=sadesenv;Password=s4d3s3nv;Initial Catalog=INSOLO_HOM1;MultipleActiveResultSets=True";

            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();

            optionsBuilder.UseMySql(connectionString);

            //optionsBuilder.UseSqlServer(connectionString);

            return new MyContext(optionsBuilder.Options);

        }
    }
}
