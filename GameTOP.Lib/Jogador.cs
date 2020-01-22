using System;
using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador: IJogador
    {
        public string nome { get; set; }

    public Jogador(string nome)
    {
        this.nome = nome;
    }
        public string Chuta()
        {
            return $"{nome} está chutando";
        }

        public string Corre()
        {
            return $"{nome} está correndo";
        }
        public string Passe()
        {
            return $"{nome} está passando";
        }
    }
}