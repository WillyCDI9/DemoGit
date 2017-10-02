using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGit2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Personne P = new Personne("Nom", "Prénom", 53);
            Console.WriteLine(P);
        }
    }
}
