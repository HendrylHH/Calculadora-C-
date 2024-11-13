using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora";
            Console.WriteLine("Calculadora");

            double valor1 = 0, valor2 = 0, resultado;
            string operador, valorDigitado;
            bool isNumeroValido;

            // Lê o primeiro valor
            Console.WriteLine("Digite o 1º valor: ");
            valorDigitado = Console.ReadLine();
            isNumeroValido = double.TryParse(valorDigitado, out valor1);
            if (!isNumeroValido)
            {
                Console.WriteLine("Digite um número válido.");
                return;
            }
            valor1 = Math.Round(valor1, 4);

            // Lê o operador
            Console.WriteLine("Digite uma operação (+, -, *, /, %): ");
            operador = Console.ReadLine();
            if (operador != "+" && operador != "-" && operador != "*" && operador != "/" && operador != "%")
            {
                Console.WriteLine("Digite uma operação válida.");
                return;
            }

            // Lê o segundo valor
            Console.WriteLine("Digite o 2º valor: ");
            valorDigitado = Console.ReadLine();
            isNumeroValido = double.TryParse(valorDigitado, out valor2);
            if (!isNumeroValido)
            {
                Console.WriteLine("Digite um número válido.");
                return;
            }
            valor2 = Math.Round(valor2, 4);

            // Realiza o cálculo com base no operador
            switch (operador)
            {
                case "+":
                    resultado = Math.Round(valor1 + valor2, 4);
                    Console.WriteLine($"{valor1} + {valor2} = {resultado}");
                    break;
                case "-":
                    resultado = Math.Round(valor1 - valor2, 4);
                    Console.WriteLine($"{valor1} - {valor2} = {resultado}");
                    break;
                case "*":
                    resultado = Math.Round(valor1 * valor2, 4);
                    Console.WriteLine($"{valor1} * {valor2} = {resultado}");
                    break;
                case "/":
                    if (valor2 == 0)
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    }
                    else
                    {
                        resultado = Math.Round(valor1 / valor2, 4);
                        Console.WriteLine($"{valor1} / {valor2} = {resultado}");
                    }
                    break;
                case "%":
                    resultado = Math.Round(valor1 * (valor2 / 100), 4);
                    Console.WriteLine($"{valor1} % de {valor2} = {resultado}");
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }

            Console.ReadKey();
        }
    }
}