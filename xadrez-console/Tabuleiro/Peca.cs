using System;
using tabuleiro;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; set; }
        public int qtdeMovimentoas { get; set; }
        public Tabuleiro tab { get; set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.qtdeMovimentoas = 0;
        }

        public void incrementarQtdeMovimnetos()
        {
            qtdeMovimentoas++;
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
