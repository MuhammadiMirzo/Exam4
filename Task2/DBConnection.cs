public abstract class DBConnection
{
    public string ConnectionString { get; set; }
    public TimeSpan Timeout { get; private set; }
    public DBConnection(string connectionString, TimeSpan timeout)
    {
        ConnectionString = connectionString;
        Timeout = timeout; 
    }
    
    public abstract void Open();
    public abstract void Close();
}