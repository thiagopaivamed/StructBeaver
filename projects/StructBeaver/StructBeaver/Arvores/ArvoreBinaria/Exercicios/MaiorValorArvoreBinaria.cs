namespace StructBeaver.Arvores.ArvoreBinaria.Exercicios
{
    public class MaiorValorArvoreBinaria
    {
        public int PegarMaiorValor(ArvoreBinaria arvoreBinaria)
        {
            if (arvoreBinaria?.Raiz is null)
                return 0;

            NoArvore raiz = arvoreBinaria.Raiz;

            if (raiz.NoEsquerdo is null && raiz.NoDireito is null)
                return raiz.Valor;

            return EncontrarMaiorValor(raiz);
        }

        private int EncontrarMaiorValor(NoArvore noArvore)
        {
            if (noArvore is null)
                return int.MinValue;

            int valorAtual = noArvore.Valor;
            int maiorEsquerda = EncontrarMaiorValor(noArvore.NoEsquerdo!);
            int maiorDireita = EncontrarMaiorValor(noArvore.NoDireito!);

            return Math.Max(valorAtual, Math.Max(maiorEsquerda, maiorDireita));
        }
    }
}