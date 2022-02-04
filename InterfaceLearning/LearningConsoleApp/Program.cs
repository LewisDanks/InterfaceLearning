using BusinessLogic;

Console.WriteLine("Hello, World!");
IDataDriver dataDriver = new SpreadsheetDataDriver();
var usr = new BusinessLogic.Models.User();
usr.AssignNameFromStringArray(dataDriver.GetName().Split(' '));
Console.WriteLine(usr.ToString());