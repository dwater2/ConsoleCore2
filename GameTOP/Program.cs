using System;
using GameTOP.Lib;
using GameTOP.Interface;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogador1 = new JogoFODA(new Jogador("Donizete"), new Jogador2());
            jogador1.IniciarJogo();

        }
    }
}