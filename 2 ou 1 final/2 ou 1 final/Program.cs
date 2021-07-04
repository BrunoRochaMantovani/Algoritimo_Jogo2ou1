using System;
using System.Collections.Generic;
using System.Text;

namespace _2_ou_1_final {
    class Program {
        static void Main(string[] args) {
            Console.Write("INFORME A QUANTIDADE DE JOGADORES....");
            int part = int.Parse(Console.ReadLine());
            Jogador Diferente;
            Jogador[] Vect = new Jogador[part];
            for (int i = 0; i<part; i++) {
                Console.Write("INFORME O NOME DO PARTICIPANTE....");
                string nome = Console.ReadLine();
                int id = new Random().Next(1, 3);
                Vect[i] = (new Jogador { Nome = nome, Resultado = id });
                
            }
            for (int i = 0; i < part; i++) {
                 if (Vect [i] != Vect [i] && Vect[i] == Vect[i]) {
                    Diferente = Vect[i];
                }
            }
            Console.WriteLine(Diferente);
        }
    }
}
