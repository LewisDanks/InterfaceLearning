using BusinessLogic;

Console.WriteLine("Hello, World!");
IDataDriver dataDriver = new TextFileDataDriver();
var usrs = dataDriver.GetUsers();
Console.WriteLine(usrs.ToArray()[0].ToString());