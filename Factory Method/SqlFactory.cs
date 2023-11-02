namespace Factory_Method;

public class SqlFactory : DbFactory 
{
    public override DbConnector CreateConnector(string connectionString)
    {
        return new SqlServerConnector(connectionString); 
    }
}