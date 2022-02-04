using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class SpreadsheetDataDriver : IDataDriver
    {
        private string fileName;
        private string connectionString;
       
        public SpreadsheetDataDriver()
        {
            fileName = string.Format(@"C:\Users\Administrator\coding\interfacetests\InterfaceLearning\InterfaceLearning\BusinessLogic\DataContainers\Users.xlsx");
            connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}; Extended Properties=Excel 12.0;", fileName);
        }
        
        public string GetName()
        {
            var adapater = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", connectionString);
            var ds = new DataSet();
            adapater.Fill(ds, "users");
            var data = ds.Tables["users"].AsEnumerable();
            return data.Select(x => string.Concat(x.Field<string>("Forenames"), " ", x.Field<string>("Surname"))).First();
        }
    }
}
