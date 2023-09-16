﻿namespace tabuleiro
{
    internal class Peca
    {
        public Posicao posicao { get; set; }
        public  Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            this.posicao = null;
            this.cor = cor;
            this.qtdMovimentos = 0;
            this.tab = tab;
        }

        public void incrementarQteMovimentos()
        {
            qtdMovimentos++;
        }
    }
}
