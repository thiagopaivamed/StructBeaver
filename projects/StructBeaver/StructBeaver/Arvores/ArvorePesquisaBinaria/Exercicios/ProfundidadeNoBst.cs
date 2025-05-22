namespace StructBeaver.Arvores.ArvorePesquisaBinaria.Exercicios
{
    public class ProfundidadeNoBst
    {
        public int ProfundidadeEmNo(ArvorePesquisaBinaria arvorePesquisaBinaria, NoArvore noProcurado)
        {
            if (arvorePesquisaBinaria?.Raiz is null || noProcurado is null)
                return -1;

            return ProfundidadePreOrdem(arvorePesquisaBinaria.Raiz, noProcurado, 0);
        }

        private int ProfundidadePreOrdem(NoArvore? noAtual, NoArvore noProcurado, int profundidade)
        {
            if (noAtual is null)
                return -1;

            if (noAtual == noProcurado)
                return profundidade;

            int profundidadeEsquerda = ProfundidadePreOrdem(noAtual.NoEsquerdo, noProcurado, profundidade + 1);
            if (profundidadeEsquerda != -1)
                return profundidadeEsquerda;

            return ProfundidadePreOrdem(noAtual.NoDireito, noProcurado, profundidade + 1);
        }
    }
}