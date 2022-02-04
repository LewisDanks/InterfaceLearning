using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class TextFileDataDriver : IDataDriver
    {
        private string dataFile;
        public TextFileDataDriver()
        {
            dataFile = @"C:\Users\Administrator\coding\interfacetests\InterfaceLearning\InterfaceLearning\BusinessLogic\DataContainers\DataFile.txt";
        }

        public string GetName()
        {
            try
            {
                using (StreamReader sr = File.OpenText(dataFile))
                {
                    return sr.ReadLine();
                }
            }
            catch(Exception e)
            {
                return e.ToString();
            }
        }
    }
}
