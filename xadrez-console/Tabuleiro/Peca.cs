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

        public bool existemMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i < tab.linhas; i++)
                for (int j = 0; j < tab.colunas; j++)
                    if (mat[i, j] == true)
                        return true;
            return false;
        }

        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
