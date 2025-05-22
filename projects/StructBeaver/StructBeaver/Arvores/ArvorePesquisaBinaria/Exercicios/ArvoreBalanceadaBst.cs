namespace StructBeaver.Arvores.ArvorePesquisaBinaria.Exercicios
{
    public class ArvoreBalanceadaBst
    {
        private bool _ehBalanceada = true;
        public bool EhBalanceada(ArvorePesquisaBinaria arvorePesquisaBinaria)
        {
            if (arvorePesquisaBinaria?.Raiz is null)
                return _ehBalanceada;

            CalcularAltura(arvorePesquisaBinaria.Raiz);

            return _ehBalanceada;
        }

        private int CalcularAltura(NoArvore? noAtual)
        {
            if (noAtual is null)
                return 0;

            int alturaEsquerda = CalcularAltura(noAtual.NoEsquerdo);
            int alturaDireita = CalcularAltura(noAtual.NoDireito);

            if (Math.Abs(alturaEsquerda - alturaDireita) > 1)
                _ehBalanceada = false;

            return Math.Max(alturaEsquerda, alturaDireita) + 1;
        }
    }
}