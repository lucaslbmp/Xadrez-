using System;
using tabuleiro;

namespace tabuleiro
{
    class Peca
    {
        Posicao posicao { get; set; }
        Cor cor { get; set; }
        public int qtdeMovimentoas { get; set; }
        public Tabuleiro tab { get; set; }

        public Peca(Posicao posicao,Tabuleiro tab, Cor cor)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.tab = tab;
            this.qtdeMovimentoas = 0;
        }
    }
}
