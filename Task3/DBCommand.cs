public class DbCommand
{
    DBConnection _connection;
    string _command;
    public DbCommand(DBConnection connection, string command)
    {
        _connection = connection;
        _command = command;
    }
    public void Execute()
    {
        _connection.Open();
        System.Console.WriteLine("Execute command: " + _command);
        _connection.Close();
    }
}