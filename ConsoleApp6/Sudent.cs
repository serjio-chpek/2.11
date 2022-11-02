using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    [Serializable]
    internal class Sudent
    {

        public string Name { get; set; }
        public string Group { get; set; }
        [NonSerialized]
        public string NumTelephone;


    }
}
