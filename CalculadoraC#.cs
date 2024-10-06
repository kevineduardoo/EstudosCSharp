using System;
using System.Linq;
using System.Collections.Generic;

namespace Calculadora;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual operação deseja fazer: ");
        Console.WriteLine("1_ Adição");
        Console.WriteLine("2_ Subtração");
        Console.WriteLine("3_ Multiplicação");
        Console.WriteLine("4_ Divisão \n");

        int operacao = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o primeiro numero: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero: ");
        int num2 = int.Parse(Console.ReadLine());

        int resultado = 0;

        switch (operacao)
        {
            case 1:
                {
                    resultado = Adição(num1, num2);
                    break;
                }

            case 2:
                {
                    resultado = Subtração(num1, num2);
                    break;
                }

            case 3:
                {
                    resultado = Multiplicação(num1, num2);
                    break;
                }

            case 4:
                {
                    resultado = Divisão(num1, num2);
                    break;
                }

            default:
                Console.WriteLine("Numero invalido,digite outro numero.");
                break;
        }

        Console.WriteLine("O resultado da operação com os números {0} e {1} é: {2}", num1, num2, resultado);

        Console.ReadLine();

    }






    public static int Adição(int numero1, int numero2)
    {
        int resultado = numero1 + numero2;
        return resultado;

    }
    public static int Subtração(int numero1, int numero2)
    {
        int resultado = numero1 - numero2;
        return resultado;
    }

    public static int Multiplicação(int numero1, int numero2)
    {
        int resultado = numero1 * numero2;
        return resultado;
    }

    public static int Divisão(int numero1, int numero2)
    {
        int resultado = numero1 / numero2;
        return resultado;
    }
}
