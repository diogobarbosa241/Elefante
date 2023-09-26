using System.Security.AccessControl;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Qual operação você deseja fazer: ");
        Console.Write("\n");
        Console.WriteLine("1- Adição");
        Console.WriteLine("2- Subtração");
        Console.WriteLine("3- Multiplicação");
        Console.WriteLine("4- Divisão \n");

        int operacao = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n Digite o primeiro número: \n");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n Digite o segundo número: \n");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int resultado = 0;

        switch (operacao)
        {
            case 1:
                {
                    resultado = adicao(num1, num2);
                    break;
                }

            case 2:
                {
                    resultado = subtracao(num1, num2);
                    break;
                }

            case 3:
                {
                    resultado = multiplicacao(num1, num2);
                    break;
                }

            case 4:
                {
                    resultado = divisao(num1, num2);
                    break;
                }

                default:
                {
                    Console.WriteLine("Número inválido, digite outro número. ");
                    break;
                }
        }

        Console.WriteLine("\n O resultado da operação é: " + resultado);
        Console.WriteLine("\n Os números utilizados na operação são o {0} e o {1}", num1, num2);
    }



    // Métodos para retornar o cálculo para cada caso (sim eu fiz da forma mais longa)
    public static int adicao(int numero1, int numero2)
    {
        int resultado = numero1 + numero2;
        return resultado;
    }

    public static int subtracao(int numero1, int numero2)
    {
        int resultado = numero1 - numero2;
        return resultado;
    }

    public static int multiplicacao(int numero1, int numero2)
    {
        int resultado = numero1 * numero2;
        return resultado;
    }

    public static int divisao(int numero1, int numero2)
    {
        int resultado = numero1 / numero2;
        return resultado;
    }
}