using BusinessLogic.Models;
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

        public IEnumerable<User> GetUsers()
        {
            string[] userStrings = File.ReadAllLines(dataFile);
            IEnumerable<User> users = new List<User>();
            return userStrings.Select(x =>
                new User
                {
                    // Lewis Daniel Danks
                    // 012345678901234567
                    Forenames = x.Substring(0, x.LastIndexOf(' ')),
                    Surname =   x.Substring(x.LastIndexOf(' ')+1)
                    //,
                    //Forenames = string.Join(' ', x.Split(' ').ToList().Where(y => y != x.Split(' ').Last())),
                    //Surname = x.Split(' ').Last()
                });

        }
    }
}
