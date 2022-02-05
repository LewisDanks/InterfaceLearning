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


        public override string ToString()
        {
            return $"{Surname}, {Forenames}";
        }
    }
}
