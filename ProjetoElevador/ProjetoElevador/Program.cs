using ProjetoElevador.Model;
using System;

namespace ProjetoElevador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------------------------");
            Console.WriteLine("BEM-VINDO (A) AO SIMULADOR DE ELEVADOR");
            Console.WriteLine("------------------------------------\n");
            Console.ResetColor();

            // Valores informados pelo usuário
            Console.Write("Informe o total de andares do prédio: ");
            int andares = int.Parse(Console.ReadLine());
            Console.Write("Informe a capacidade do elevador: ");
            int capacidade = int.Parse(Console.ReadLine());

            // Instanciação de um objeto da classe Elevador
            Elevador elevador = new Elevador(andares, capacidade);

            bool ativo = true;

            // Estrutura de repetição que irá primeiro apresentar na tela as ações do menu e depois verificar se a variável "ativo" é verdadeira, caso seja irá repetir 
            do
            {
                Console.WriteLine(elevador);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nEscolha uma opção: 1-[Entrar]  2-[Sair]  3-[Subir]  4-[Descer]  5-[Encerrar]");
                Console.ResetColor();
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        elevador.Entrar();
                        break;

                    case "2":
                        elevador.Sair();
                        break;

                    case "3":
                        elevador.Subir();
                        break;

                    case "4":
                        elevador.Descer();
                        break;

                    case "5":
                        ativo = false;
                        Console.WriteLine("O sistema será encerrado. Obrigada por utilizar o simulador de elevador.");
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Opção inválida! Digite uma opção válida no menu.");
                        Console.ResetColor();
                        break;
                }

            } while (ativo);

        }
    }
}
