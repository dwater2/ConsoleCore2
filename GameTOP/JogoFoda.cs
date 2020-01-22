using System;
using GameTOP.Interface;

namespace GameTOP
{
class JogoFODA{
        private readonly IJogador jogador;
        private readonly IJogador jogador2;

        public JogoFODA(IJogador jogador1, IJogador jogador2)
        {
            this.jogador = jogador1;
            this.jogador2 = jogador2;
        }
        public void IniciarJogo(){
            Console.WriteLine(this.jogador.Corre());
            Console.WriteLine(this.jogador.Passe());
            Console.WriteLine(this.jogador.Chuta());

            Console.WriteLine(this.jogador2.Corre());
            Console.WriteLine(this.jogador2.Passe());
            Console.WriteLine(this.jogador2.Chuta());
        }
    }
}