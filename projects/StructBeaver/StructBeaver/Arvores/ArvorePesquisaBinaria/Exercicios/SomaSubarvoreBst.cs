namespace StructBeaver.Arvores.ArvorePesquisaBinaria.Exercicios
{
    public class SomaSubarvoreBst
    {
        public ArvorePesquisaBinaria? SubstituirPorSomaSubarvore(ArvorePesquisaBinaria arvore)
        {
            if (arvore?.Raiz is null)
                return arvore;

            Substituir(arvore.Raiz);
            return arvore;
        }

        private int Substituir(NoArvore noAtual)
        {
            if (noAtual is null)
                return 0;

            int somaEsquerda = Substituir(noAtual.NoEsquerdo!);
            int somaDireita = Substituir(noAtual.NoDireito!);

            int novoValor = somaEsquerda + somaDireita + noAtual.Valor;
            noAtual.Valor = novoValor;

            return novoValor;
        }
    }
}
