namespace Factory_Method;

public abstract class DbFactory
{
    public abstract DbConnector CreateConnector(string connectionString);

    public static DbFactory Database(DataBase dataBase)
    {
        //return new SqlFactory();

        return dataBase switch
        {
            DataBase.Nike => new SqlFactory(),
            DataBase.Inbound => new SqlFactory(),
            _ => throw new ApplicationException("Database not recognized.")
        };
    }
}