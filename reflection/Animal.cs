using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflection
{
    public class Animal
    {
        public string Som { get; set; }

        public void EmitirSom(string som)
        {
            Som = som;
            Console.WriteLine(Som);
        }
    }
}
