
 var oracle = new OracleConnection("Connect", TimeSpan.FromMinutes(2));
 var sql = new SqlConnection("Connect", TimeSpan.FromMinutes(2));
 var command = new DbCommand(sql," insert into students");
 var command1 = new DbCommand(oracle," insert into students");
 System.Console.WriteLine();
 command.Execute();
 System.Console.WriteLine();
 command1.Execute();