using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public class User
    {
        public string Forenames { get; set; }
        public string Surname { get; set; } 

        public void AssignNameFromStringArray(IEnumerable<string> name)
        {
           Surname = name.Last();
           foreach (var item in name.Select((value, i) => new {i, value }).Where(x => x.value != Surname))
            {
                if(item.i == 0)
                {
                    Forenames = item.value;
                }
                else
                {
                    Forenames += item.value;
                }
            }
        }

        public override string ToString()
        {
            return $"{Surname}, {Forenames}";
        }
    }
}
