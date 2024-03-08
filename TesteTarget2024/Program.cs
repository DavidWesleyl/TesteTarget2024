using System.Collections.Specialized;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {

        // Primeiro Desafio 

        Console.WriteLine("=> Desafio 1");
        Console.WriteLine();

        int indice = 13, soma = 0, k = 0;

        while (k < indice)
        {
            k = k + 1;
            soma = soma + k;
        }


        Console.WriteLine($"Resultado: {soma}");


        Console.WriteLine();

        Console.WriteLine("------------------------------------------------------------------------------------------");


        // Segundo Desafio
        Console.WriteLine();


        Console.WriteLine("=> Desafio 2");

        Console.WriteLine();

        Console.WriteLine("Sequencia Finonacci");

        Console.WriteLine();

        int primeiroValor = 0;

        int segundoValor = 1;

        int somaNumero = 0;




        Console.Write("Digite um valor para ver se pertence a sequencia Fibonacci: ");

        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine();

        for (int i = 1; i < 10; i++)
        {
            somaNumero = primeiroValor + segundoValor;
            segundoValor = primeiroValor;
            primeiroValor = somaNumero;


            Console.WriteLine();

            Console.WriteLine($"{somaNumero}");

            Console.WriteLine();



        }



        if (Fibonacci(numero))
        {
            Console.WriteLine(" *** O numero digitado pertence a sequencia Fibonacci ***");
        }

        else
        {
            Console.WriteLine("*** O numero digitado, NÃO pertence a sequencia Fibonacci *** ");
        }



        static bool Fibonacci(int numero)
        {
            int primeiroNumero = 0;
            int segundoNumero = 1;

            while (primeiroNumero < numero)
            {
                int somaValores = primeiroNumero;
                primeiroNumero = segundoNumero;
                segundoNumero = somaValores + primeiroNumero;

            }

            return primeiroNumero == numero;
        }

        Console.WriteLine();

        Console.WriteLine("-----------------------------------------------------------------------------------------");

        // Terceiro Desafio

        Console.WriteLine();

        Console.WriteLine("=> Desafio 5");


        Console.WriteLine();

        Console.Write("Digite uma frase para inverter: ");

        string fraseIvertida = Console.ReadLine();

        string texto = Inverter(fraseIvertida);

        Console.WriteLine();

        Console.WriteLine($"Texto Invertido: {texto}");



        static string Inverter(string frase)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int inicio = frase.Length - 1; inicio >= 0; inicio--)
            {
                stringBuilder.Append(frase[inicio]);
            }

            return stringBuilder.ToString();
        }





        // Observação: Respostas dos Desafios 3 e 4.



        /* Desafio 3:
         * A) 9 [Pulam de dois em dois]
         * 
         * B) 128, somando os valores +2
         * 
         * C) 49 [A contagem de um para o outro é de dois em dois. Por exemplo, do 4 ao 9, são 5 casas de diferença, do 9 ao 16, são 7 casas de diferença. casas => 5 - 7 - 9 - 11 => 13]
         * 
         * D) 100. [4, 16, 36, 64, associamos os 4 valores à 4 numeros pares. por exemplo: 2, 4, 6, 8 e elevamos ao quadrado. 2^2 = 4, 4^2 = 16, 6^2 = 36, 8^2 = 64, 10^2 = 100
         * 
         * E) Sequencia fibonacci, soma com o antecessor
         * 
         * F) Todos começam com D
         * 
         * 
         * 
         */


        /* Desafio 4
         * 
         * Honestamente, já havia visto esse desafio, porém a pergunta formulada na questão está confusa, então responderei da forma que sei:
         * 
         * Ligo a primeira lampada por alguns minutos, depois ligo a segunda. A lampada que estiver quente, corresponde a primeira, a segunda estará acessa e a terceira apagada.
         
         */






























    }
}