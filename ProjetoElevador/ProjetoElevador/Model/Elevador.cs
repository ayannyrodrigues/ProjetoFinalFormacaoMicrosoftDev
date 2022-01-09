using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    class Elevador
    {
        // Atributos da classe 
        public int andarAtual { get; set; }
        public int totalAndares { get; set; }
        public int capacidadeElevador { get; set; }
        public int qntdPessoas { get; set; }


        // Construtor
        public Elevador(int totalAndares, int capacidadeElevador)
        {
            this.andarAtual = 0;
            this.totalAndares = totalAndares;
            this.capacidadeElevador = capacidadeElevador;
            this.qntdPessoas = 0;
        }


        // Métodos
        public int Entrar()
        {
            if (qntdPessoas < capacidadeElevador)
            {
                qntdPessoas++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("O elevador está cheio. Por gentileza, aguarde o próximo.");
                Console.ResetColor();
            }

            return qntdPessoas;
        }

        // Remove uma pessoa do elevador
        public int Sair()
        {
            if (qntdPessoas != 0)
            {
                qntdPessoas--;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("O elevador está vazio.");
                Console.ResetColor();
            }

            return qntdPessoas;
        }

        // Sobe um andar 
        public int Subir()
        {
            if (andarAtual < totalAndares)
            {
                andarAtual++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Você chegou ao último andar, não é possível subir.");
                Console.ResetColor();
            }

            return andarAtual;
        }

        // Desce um andar
        public int Descer()
        {
            if (andarAtual != 0)
            {
                andarAtual--;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Você chegou ao terréo, não é possível descer.");
                Console.ResetColor();
            }

            return andarAtual;
        }


        // Reescreve o método ToString
        public override string ToString()
        {
            return "\nAndar atual: " + andarAtual + "º" + "\n" + "Quantidade de pessoas dentro do elevador: " + qntdPessoas;

        }
    }
}
