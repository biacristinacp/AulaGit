using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes =
            {
                "Beatriz Cerqueira",
                "Gabriela Lima",
                "Julia Miranda",
                "Fernanda Paiva" };

            foreach(var nome in nomes) { 
                //Imprime os valores do array
                Console.WriteLine(nome);
            }
            //Segura o resultado, para a tela esperando feedback do usuário
            Console.ReadKey();
        }
    }
}

