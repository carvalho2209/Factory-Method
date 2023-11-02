namespace Factory_Method;

public class SqlServerConnector : DbConnector
{
    public SqlServerConnector(string connectionString) 
        : base(connectionString)
    {
        ConnectionString = connectionString;
    }

    public override Connection Connect()
    {
        Console.WriteLine("Connecting to Database {0}", ConnectionString);
        var connection = new Connection(ConnectionString);
        connection.Open();

        return connection;
    }
}