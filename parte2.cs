using System;

namespace MetodosSobrecarregados
{
    class Program
    {
        /// <summary>
        /// Método principal que testa todas as funcionalidades implementadas
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Teste de Métodos com Sobrecarga");
            Console.WriteLine("===============================");
            
            // Teste do método de soma
            int resultadoSoma = AddNumbers(15, 27);
            Console.WriteLine($"Soma de 15 e 27: {resultadoSoma}");
            
            // Teste do método de saudação
            string saudacao = Greeting("Ana");
            Console.WriteLine(saudacao);
            
            // Teste dos métodos de área
            double areaRet = CalculateRectangleArea(8.5, 4.2);
            Console.WriteLine($"Área do retângulo (8.5x4.2): {areaRet:F2}");
            
            double areaTri = CalculateTriangleArea(7.3, 5.1);
            Console.WriteLine($"Área do triângulo (base 7.3, altura 5.1): {areaTri:F2}");
            
            // Teste da sobrecarga do método Multiply
            int multInt = Multiply(6, 9);
            Console.WriteLine($"Multiplicação inteira (6x9): {multInt}");
            
            double multDouble = Multiply(3.7, 2.8);
            Console.WriteLine($"Multiplicação decimal (3.7x2.8): {multDouble:F2}");
            
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
        
        /// <summary>
        /// Realiza a soma de dois números inteiros
        /// </summary>
        /// <param name="number1">Primeiro número a ser somado</param>
        /// <param name="number2">Segundo número a ser somado</param>
        /// <returns>Resultado da soma dos dois números</returns>
        static int AddNumbers(int number1, int number2)
        {
            return number1 + number2;
        }
        
        /// <summary>
        /// Cria uma mensagem de saudação personalizada
        /// </summary>
        /// <param name="userName">Nome do usuário a ser saudado</param>
        /// <returns>Mensagem de saudação com o nome do usuário</returns>
        static string Greeting(string userName)
        {
            return $"Olá, {userName}! Seja bem-vindo ao programa!";
        }
        
        /// <summary>
        /// Calcula a área de um retângulo
        /// </summary>
        /// <param name="length">Comprimento do retângulo</param>
        /// <param name="width">Largura do retângulo</param>
        /// <returns>Área calculada do retângulo</returns>
        static double CalculateRectangleArea(double length, double width)
        {
            return length * width;
        }
        
        /// <summary>
        /// Calcula a área de um triângulo
        /// </summary>
        /// <param name="baseTriangle">Base do triângulo</param>
        /// <param name="height">Altura do triângulo</param>
        /// <returns>Área calculada do triângulo</returns>
        static double CalculateTriangleArea(double baseTriangle, double height)
        {
            return (baseTriangle * height) / 2;
        }
        
        /// <summary>
        /// Multiplica dois números inteiros
        /// </summary>
        /// <param name="number1">Primeiro fator da multiplicação</param>
        /// <param name="number2">Segundo fator da multiplicação</param>
        /// <returns>Produto dos dois números inteiros</returns>
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        
        /// <summary>
        /// Multiplica dois números de ponto flutuante
        /// </summary>
        /// <param name="number1">Primeiro fator da multiplicação</param>
        /// <param name="number2">Segundo fator da multiplicação</param>
        /// <returns>Produto dos dois números decimais</returns>
        static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }
    }
}