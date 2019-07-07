using System;
using tabuleiro;

namespace xadrez
{
    class Peao : Peca
    {
        public Peao(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        private bool existeInimigo(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p != null && p.cor != cor;
        }

        private bool livre(Posicao pos)
        {
            return tab.peca(pos) == null;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);
            if(cor == Cor.Branca)
            {
                // frente
                pos.definirValores(posicao.linha - 1, posicao.coluna);
                if(tab.posicaoValida(pos) && livre(pos))
                    mat[pos.linha, pos.coluna] = true;

                // frente (1a vez)
                pos.definirValores(posicao.linha - 2, posicao.coluna);
                if (tab.posicaoValida(pos) && livre(pos) && qtdeMovimentoas == 0)
                    mat[pos.linha, pos.coluna] = true;

                // diagonal (direita)
                pos.definirValores(posicao.linha - 1, posicao.coluna +1);
                if (tab.posicaoValida(pos) && existeInimigo(pos))
                    mat[pos.linha, pos.coluna] = true;

                // diagonal (esquerda)
                pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
                if (tab.posicaoValida(pos) && existeInimigo(pos))
                    mat[pos.linha, pos.coluna] = true;
            }
            else
            {
                // frente
                pos.definirValores(posicao.linha + 1, posicao.coluna);
                if (tab.posicaoValida(pos) && livre(pos))
                    mat[pos.linha, pos.coluna] = true;

                // frente (1a vez)
                pos.definirValores(posicao.linha + 2, posicao.coluna);
                if (tab.posicaoValida(pos) && livre(pos) && qtdeMovimentoas == 0)
                    mat[pos.linha, pos.coluna] = true;

                // diagonal (direita)
                pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
                if (tab.posicaoValida(pos) && existeInimigo(pos))
                    mat[pos.linha, pos.coluna] = true;

                // diagonal (esquerda)
                pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
                if (tab.posicaoValida(pos) && existeInimigo(pos))
                    mat[pos.linha, pos.coluna] = true;
            }
            return mat;
        }
        public override string ToString()
        {
            return " P";
        }
    }
}
