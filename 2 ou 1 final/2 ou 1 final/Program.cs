using System;
using System.Collections.Generic;
using System.Text;

namespace _2_ou_1_final {
    class Program {
        static void Main(string[] args) {

            Console.Write("INFORME A QUANTIDADE DE PARTICIPANTES..");
            int part = int.Parse(Console.ReadLine());
            Funcionalidade(part);
            Console.WriteLine("GERAR NOVAMENTE ? (y/n)");
            char Escolha = char.Parse(Console.ReadLine());
            while (Escolha == 'y' || Escolha == 'Y') {
                Funcionalidade(part);
                Console.WriteLine("GERAR NOVAMENTE ? (y/n)");
                Escolha = char.Parse(Console.ReadLine());
            }
        }
        public static void Funcionalidade(int Part) {
            List<Jogador> mainlist = new List<Jogador>();
            List<Jogador> List01 = new List<Jogador>();
            List<Jogador> List02 = new List<Jogador>();
            for (int i = 0; i < Part; i++) {
                Console.Write("INFORME O NOME DO JOGADOR...");
                string nome = Console.ReadLine();
                int numero = new Random().Next(1, 3);
                mainlist.Add(new Jogador { Nome = nome, Resultado = numero });
            }
            foreach (Jogador Obj in mainlist) {
                int Ref = 1;

                if (Obj.Resultado != Ref) {
                    List02.Add(new Jogador { Nome = Obj.Nome, Resultado = Obj.Resultado });
                } else {
                    List01.Add(new Jogador { Nome = Obj.Nome, Resultado = Obj.Resultado });
                }

            }
            foreach (Jogador Obj in List01) {
                Console.WriteLine("\nJOGADORES QUE ESCOLHERAM O 1: " + Obj.Nome + " ESCOLHA: " + Obj.Resultado + "\n");

            }
            foreach (Jogador Obj in List02) {
                Console.WriteLine("\nJOGADORES QUE ESCOLHERAM O 2: " + Obj.Nome + " ESCOLHA: " + Obj.Resultado + "\n");

            }
        }
    }
}
