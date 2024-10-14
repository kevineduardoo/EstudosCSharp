using System;
using System.Linq;
using System.Collections.Generic;

namespace aprendizado3;

class Program
{
    static void Main()
    {
        string[] names = { "Kevin", "Stéfanie", "Luka", "Pudim" };  // Syntactic sugar(basicamente e uma funcionabilidade no compilador q permite q a gente digite menos codigos pra certas 

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

    }

}


