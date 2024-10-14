using System;
using System.Linq;
using System.Collections.Generic;

namespace Aprendizado;

class Usandofor
{
    static void Main()
    {
        string[] names = { "Kevin", "Stéfanie", "Luka", "Pudim" };  // Syntactic sugar(basicamente e uma funcionabilidade no compilador q permite q a gente digite menos codigos pra certas 

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(names[i]);
        }

    }

}


