using Factory_Method;

var connNike = DbFactory
    .Database(DataBase.Nike)
    .CreateConnector("connectionStringNike")
    .Connect();

connNike.ExecuteCommand("Select * From NikeTable");
connNike.Close();

Console.WriteLine("");
Console.WriteLine("_____________________________");
Console.WriteLine(""); 

var connIn = DbFactory
    .Database(DataBase.Inbound)
    .CreateConnector("connectionStringInbound")
    .Connect();

connIn.ExecuteCommand("Select * From InboundTable");
connIn.Close();

//https://dofactory.com/net/factory-method-design-pattern