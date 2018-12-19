using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boucle4
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            for(count =10; count >=0/* possibilité de mettre un chiffre negatif*/; count--)
            {
                Console.WriteLine(count);
            }
        }
    }
}
