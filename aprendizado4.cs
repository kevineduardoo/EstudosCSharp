using System;

namespace Aprendizado4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Kevin", "Stéfanie", "Luka", "Pudim" };

            // Usando string.Equals para comparar ignorando diferença entre maiúsculas e minúsculas
            if (string.Equals(names[0], "kevin", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Igual");
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
