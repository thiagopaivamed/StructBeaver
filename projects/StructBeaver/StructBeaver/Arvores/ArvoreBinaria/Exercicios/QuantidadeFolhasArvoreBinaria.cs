namespace StructBeaver.Arvores.ArvoreBinaria.Exercicios
{
    public class QuantidadeFolhasArvoreBinaria
    {
        public int ContarFolhas(ArvoreBinaria arvoreBinaria)
        {
            if (arvoreBinaria?.Raiz is null)
                return 0;

            NoArvore raiz = arvoreBinaria.Raiz;

            return Contar(raiz);
        }

        private int Contar(NoArvore noAtual)
        {
            if (noAtual.NoEsquerdo is null && noAtual.NoDireito is null)
                return 1;

            int quantidadeFolhas = 0;

            if (noAtual.NoEsquerdo is not null)
                quantidadeFolhas = quantidadeFolhas + Contar(noAtual.NoEsquerdo);
            if (noAtual.NoDireito is not null)
                quantidadeFolhas = quantidadeFolhas + Contar(noAtual.NoDireito);

            return quantidadeFolhas;
        }
    }
}