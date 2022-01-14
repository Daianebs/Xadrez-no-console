using System;
using tabuleiro;
using xadrez;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {
            Posicaoxadrez pos = new Posicaoxadrez('a', 1);
            Posicaoxadrez pos2 = new Posicaoxadrez('c', 7);
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
            Console.WriteLine(pos2.toPosicao());
        }
    }
}
