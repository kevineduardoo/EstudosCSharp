using System;
using System.Linq;
using System.Collections.Generic;

namespace CalculoMaioriadade;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite seu nome;");
        string name = Console.ReadLine();
        Console.WriteLine($"Olá {name}! ");
        Console.Write("Digite o ano do seu nascimento: ");
        int year = int.Parse(Console.ReadLine());
        int age = 2024 - year; //+,-,*,/
        Console.WriteLine($"Voce tem {age} anos.");

        if (age >= 18)
        {
            Console.WriteLine("Voce é maior de idade. ");
        }
        else
        {
            Console.WriteLine("Voce é menor de idade. ");
        }
    }
}

