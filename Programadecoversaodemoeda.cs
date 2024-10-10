using System;
using System.Linq;
using System.Collections.Generic;

namespace Coversordemoeda;

class Programadecoversaodemoeda
{
    static void Main(string[] args)
    {
        string ValorDigitadoEmReal = "";
        decimal ValorConvertido;
        decimal ValorEmDolar;
        decimal CotacaoDoDolarHoje = 5.58M;
        Console.WriteLine("Digite o valor que deseja converter: ");

        ValorDigitadoEmReal = Console.ReadLine();
        if (!Decimal.TryParse(ValorDigitadoEmReal, out ValorConvertido))
        {
            Console.WriteLine("Digite um valor válido. Não foi possível converter '{0}'.", ValorDigitadoEmReal);
        }

        ValorEmDolar = ValorConvertido * CotacaoDoDolarHoje;

        Console.WriteLine("Valor R$ {0} convertido em dolar é: R$ {1}", ValorDigitadoEmReal, ValorEmDolar);
    }


}
