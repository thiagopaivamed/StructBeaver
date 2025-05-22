namespace StructBeaver.Arvores.ArvorePesquisaBinaria.Exercicios
{
    public class QuantidadeNosDoisFilhosBst
    {
        public int ContarNosDoisFilhos(ArvorePesquisaBinaria arvorePesquisaBinaria)
        {
            if (arvorePesquisaBinaria?.Raiz is null)
                return 0;

            return Contar(arvorePesquisaBinaria.Raiz);
        }

        private int Contar(NoArvore? noAtual)
        {
            if (noAtual is null)
                return 0;

            int quantidadeNosDoisFilhos = 0;

            if (noAtual.NoEsquerdo is not null && noAtual.NoDireito is not null)
                quantidadeNosDoisFilhos = 1;

            quantidadeNosDoisFilhos = quantidadeNosDoisFilhos + Contar(noAtual.NoEsquerdo);
            quantidadeNosDoisFilhos = quantidadeNosDoisFilhos + Contar(noAtual.NoDireito);

            return quantidadeNosDoisFilhos;
        }
    }
}