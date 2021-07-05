using System;
using System.Collections.Generic;
using System.Text;

namespace _2_ou_1_final {
    class Program {
        static void Main(string[] args) {

            Console.Write("INFORME A QUANTIDADE DE PARTICIPANTES..");
            int part = int.Parse(Console.ReadLine());
            Jogador[,] Mat = new Jogador[part, part];
          for (int i = 0; i<part; i++) {
                Console.Write("INFORME O NOME DO PARTICIPANTE...");
                string nome = Console.ReadLine();
                int val = new Random().Next(1, 2);
                var row = new string[]; 
                
                for (int j = 0; j<part; j++) {

                }
            }
        }
    }
}
