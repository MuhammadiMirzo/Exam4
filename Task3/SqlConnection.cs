
public class SqlConnection : DBConnection
{
    public SqlConnection(string connectionsring, TimeSpan timeout)
    :base (connectionsring,timeout)
    {
        
    }
    public override void Close()
    {
     System.Console.WriteLine("SqlConnection is closed");
    }


    public override void Open()
    {
        Console.WriteLine("SqlConnection is open");
    }
   
}