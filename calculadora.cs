using System;

class Calculadora
{
    static void Main()
    {
        double num1, num2, resultado;
        char operador;

        Console.WriteLine("Calculadora");
        Console.WriteLine("-------------------------");

        Console.Write("Digite o primeiro número: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o operador (+, -, *, /): ");
        operador = Convert.ToChar(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        switch (operador)
        {
            case '+':
                resultado = num1 + num2;
                Console.WriteLine("Resultado: " + resultado);
                break;

            case '-':
                resultado = num1 - num2;
                Console.WriteLine("Resultado: " + resultado);
                break;

            case '*':
                resultado = num1 * num2;
                Console.WriteLine("Resultado: " + resultado);
                break;

            case '/':
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine("Resultado: " + resultado);
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero.");
                }
                break;

            default:
                Console.WriteLine("Operador inválido.");
                break;
        }

        Console.ReadLine();
    }
}
