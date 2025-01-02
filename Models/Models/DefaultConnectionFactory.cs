namespace Models.Models
{
    public class DefaultConnectionFactory
    {
        private readonly string _connectionString;

        public DefaultConnectionFactory()
        {
            _connectionString = "data source=172.17.16.14;initial catalog=ICTV3;user id=sa;password=Welcome99";
        }

        public DefaultConnection CreateDbContext()
        {
            return DefaultConnection.Create(_connectionString);
        }
    }
}
