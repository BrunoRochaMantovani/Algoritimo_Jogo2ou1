using System;

namespace _2_OU_1 {
    class Program {
        static void Main(string[] args) {
           
            Console.Write("INFORME A QUANTIDADE DE PARTICIPANTES....");
            int Part = int.Parse(Console.ReadLine());
            for (int i = 0; i < Part; i++) {
                Console.Write("INFORME O NOME DO JOGAR...");
                String nome = Console.ReadLine();
                int id = new Random().Next(1, 2);
            }
        }
    }
}
