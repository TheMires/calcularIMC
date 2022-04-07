using System;

namespace CalculodeIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float altura;
            float peso;
            float imc;

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua altura (use vírgula): ");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu peso: ");
            peso = float.Parse(Console.ReadLine());

            imc = (peso / (altura * altura));

            Console.WriteLine(nome + ", seu IMC é: " + imc);

            if (imc < 18.5)
            {
                Console.WriteLine("Ah não parça, você está com o peso abaixo do normal");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Show de bola! Seu peso está normal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Eita meu chapa, você está com sobrepeso");
            }

            else
            {
                Console.WriteLine("Que pena meu consagrado, você está com obesidade");
            }
        }
    }
}
