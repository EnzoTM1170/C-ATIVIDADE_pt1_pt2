using System;

namespace AreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Área de Círculo");
            Console.WriteLine("==============================");
            
            // Solicita o nome do usuário
            Console.Write("Por favor, digite seu nome: ");
            string nome = Console.ReadLine();
            
            // Solicita o raio do círculo
            Console.Write("Agora digite o raio do círculo: ");
            double raio;
            
            // Verifica se o valor digitado é válido
            while (!double.TryParse(Console.ReadLine(), out raio) || raio <= 0)
            {
                Console.Write("Valor inválido! Digite um número positivo para o raio: ");
            }
            
            // Calcula a área
            double area = Math.PI * Math.Pow(raio, 2);
            
            // Exibe o resultado
            Console.WriteLine($"{nome}, a área do círculo é: {area:F2}");
            
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}