public class OracleConnection : DBConnection
{
    public OracleConnection(string connectionstring, TimeSpan timespan)
    : base(connectionstring,timespan)
    {
        
    }
    public override void Close()
    {
         Console.WriteLine("MysqlConnection is closed ");
    }

    public override void Open()
    {
         Console.WriteLine("MysqlConnection is open");
    }

}