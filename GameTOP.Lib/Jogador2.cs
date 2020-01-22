using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : IJogador
    {
        public string Chuta()
        {
            return "Jogador2 está chutando";
        }

        public string Corre()
        {
            return "Jogador2 está correndo";
        }

        public string Passe()
        {
            return "Jogador2 está passando";
        }
    }
}