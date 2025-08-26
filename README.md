Exercícios de Programação em C#
📋 Sobre os Projetos
Estes são dois programas em C# desenvolvidos como exercícios acadêmicos para praticar conceitos de programação, incluindo métodos, sobrecarga e documentação.

🎯 Exercício 1: Calculadora de Área de Círculo
Descrição
Programa que calcula a área de um círculo com base no raio fornecido pelo usuário e exibe uma mensagem personalizada.

Funcionalidades
Solicita o nome do usuário

Pede o valor do raio do círculo

Valida se o valor do raio é positivo

Calcula a área usando a fórmula: π × raio²

Exibe resultado formatado com duas casas decimais

Como Executar
Abra o projeto no Visual Studio

Compile o código (Ctrl + Shift + B)

Execute o programa (F5)

Siga as instruções no console

Exemplo de Uso
text
Calculadora de Área de Círculo
==============================
Por favor, digite seu nome: Maria
Agora digite o raio do círculo: 5
Maria, a área do círculo é: 78,54
Código
csharp
using System;

namespace AreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Área de Círculo");
            Console.WriteLine("==============================");
            
            Console.Write("Por favor, digite seu nome: ");
            string nome = Console.ReadLine();
            
            Console.Write("Agora digite o raio do círculo: ");
            double raio;
            
            while (!double.TryParse(Console.ReadLine(), out raio) || raio <= 0)
            {
                Console.Write("Valor inválido! Digite um número positivo para o raio: ");
            }
            
            double area = Math.PI * Math.Pow(raio, 2);
            
            Console.WriteLine($"{nome}, a área do círculo é: {area:F2}");
            
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
🎯 Exercício 2: Métodos com Sobrecarga
Descrição
Programa que demonstra a implementação de diversos métodos com sobrecarga e documentação XML.

Métodos Implementados
1. AddNumbers()
Função: Soma dois números inteiros

Parâmetros: number1 (int), number2 (int)

Retorno: int (soma dos números)

2. Greeting()
Função: Cria saudação personalizada

Parâmetros: userName (string)

Retorno: string (mensagem de saudação)

3. CalculateRectangleArea()
Função: Calcula área do retângulo

Parâmetros: length (double), width (double)

Retorno: double (área calculada)

4. CalculateTriangleArea()
Função: Calcula área do triângulo

Parâmetros: baseTriangle (double), height (double)

Retorno: double (área calculada)

5. Multiply() - Sobrecarga
Versão 1: Multiplica dois inteiros

Versão 2: Multiplica dois números decimais

Como Executar
Abra o projeto no Visual Studio

Compile o código (Ctrl + Shift + B)

Execute o programa (F5)

Observe os testes automáticos no console

Exemplo de Saída
text
Teste de Métodos com Sobrecarga
===============================
Soma de 15 e 27: 42
Olá, Ana! Seja bem-vindo ao programa!
Área do retângulo (8,5x4,2): 35,70
Área do triângulo (base 7,3, altura 5,1): 18,62
Multiplicação inteira (6x9): 54
Multiplicação decimal (3,7x2,8): 10,36
Código
csharp
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
            
            int resultadoSoma = AddNumbers(15, 27);
            Console.WriteLine($"Soma de 15 e 27: {resultadoSoma}");
            
            string saudacao = Greeting("Ana");
            Console.WriteLine(saudacao);
            
            double areaRet = CalculateRectangleArea(8.5, 4.2);
            Console.WriteLine($"Área do retângulo (8.5x4.2): {areaRet:F2}");
            
            double areaTri = CalculateTriangleArea(7.3, 5.1);
            Console.WriteLine($"Área do triângulo (base 7.3, altura 5.1): {areaTri:F2}");
            
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
🛠️ Tecnologias Utilizadas
Linguagem: C#

Plataforma: .NET

IDE: Visual Studio

Recursos: Métodos, Sobrecarga, Documentação XML
