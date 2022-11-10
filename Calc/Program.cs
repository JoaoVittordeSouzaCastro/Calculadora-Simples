using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual Operação Deseja Fazer? ");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão \n");

            int operacao = int.Parse(Console.ReadLine());
            Console.WriteLine("Digitr o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digitr o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

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
                    Console.WriteLine("Opção Invalido");
                    break;
            }
            Console.WriteLine("O resultado da Operação com os números {0} e {1} é: {2}", num1, num2, resultado);
            Console.ReadLine();
        }
        public static int adicao(int num1, int num2)
        { 
            int resultado = num1 + num2;
            return resultado;
        }
        public static int Subtração(int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado;
        }
        public static int Multiplicação(int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }
        public static int Divisão(int num1, int num2)
        {
            int resultado = num1 / num2;
            return resultado;
        }
     
    }
}
