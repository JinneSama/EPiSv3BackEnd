using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;

namespace Models.Models
{
    public partial class DefaultConnection
    {
        public DefaultConnection(string connectionString)
        : base(connectionString)
        {
        }
        public static DefaultConnection Create()
        {
            return new DefaultConnection();
        }
        public static DefaultConnection Create(string providerConnectionString)
        {
            var entityBuilder = new EntityConnectionStringBuilder();

            entityBuilder.ProviderConnectionString = providerConnectionString;

            entityBuilder.Provider = "System.Data.SqlClient";

            entityBuilder.Metadata = @"res://*/Models.ModelDB.csdl|res://*/Models.ModelDB.ssdl|res://*/Models.ModelDB.msl";

            return new DefaultConnection(entityBuilder.ConnectionString);
        }
        public void FixEfProviderServicesProblem()
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
        public static void SetConnection(string connection, string userName, string password)
        {

        }
    }
    public static class DataSource
    {
        public static string ConnectionString { get; set; }
    }
}

