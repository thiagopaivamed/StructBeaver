namespace StructBeaver.Arvores.Avl
{
    public class ArvoreAvl (NoAvl raizAvl)
    {
        public NoAvl RaizAvl = raizAvl;

        private int PegarAlturaNo(NoAvl? noAvl)
            => noAvl?.Altura ?? 0;

        private int FatorBalanceamento(NoAvl? no)
        {
            if (no is null)
                return 0;

            return PegarAlturaNo(no.NoEsquerdo) - PegarAlturaNo(no.NoDireito);
        }

        private void AtualizarAltura(NoAvl no)
        {
            int alturaNoEsquerdo = PegarAlturaNo(no.NoEsquerdo);
            int alturaNoDireito = PegarAlturaNo(no.NoDireito);
            no.Altura = Math.Max(alturaNoEsquerdo, alturaNoDireito) + 1;
        }

        private NoAvl RotacaoSimplesDireita(NoAvl noAtual)
        {
            NoAvl filhoEsquerdo = noAtual.NoEsquerdo;
            NoAvl subarvoreDireitaDoFilho = filhoEsquerdo.NoDireito;

            // Rotaciona
            filhoEsquerdo.NoDireito = noAtual;
            noAtual.NoEsquerdo = subarvoreDireitaDoFilho;

            // Atualiza alturas
            AtualizarAltura(noAtual);
            AtualizarAltura(filhoEsquerdo);

            return filhoEsquerdo;
        }

        private NoAvl RotacaoSimplesEsquerda(NoAvl noAtual)
        {
            NoAvl filhoDireito = noAtual.NoDireito;
            NoAvl subarvoreEsquerdaDoFilho = filhoDireito.NoEsquerdo;

            // Rotaciona
            filhoDireito.NoEsquerdo = noAtual;
            noAtual.NoDireito = subarvoreEsquerdaDoFilho;

            // Atualiza alturas
            AtualizarAltura(noAtual);
            AtualizarAltura(filhoDireito);

            return filhoDireito;
        }

        private NoAvl RotacaoDuplaEsquerdaDireita(NoAvl noAtual)
        {
            noAtual.NoEsquerdo = RotacaoSimplesEsquerda(noAtual.NoEsquerdo);
            return RotacaoSimplesDireita(noAtual);
        }

        private NoAvl RotacaoDuplaDireitaEsquerda(NoAvl noAtual)
        {
            noAtual.NoDireito = RotacaoSimplesDireita(noAtual.NoDireito);
            return RotacaoSimplesEsquerda(noAtual);
        }
    }
}
