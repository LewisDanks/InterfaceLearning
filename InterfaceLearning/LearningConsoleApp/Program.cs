using BusinessLogic;

Console.WriteLine("Hello, World!");
IDataDriver dataDriver = new TextFileDataDriver();
var usr = new BusinessLogic.Models.User();
usr.AssignNameFromStringArray(dataDriver.GetName().Split(' '));
Console.WriteLine(usr.ToString());