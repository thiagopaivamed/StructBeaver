namespace StructBeaver.Arvores.ArvorePesquisaBinaria.Exercicios
{
    public class DiametroBst
    {
        private int _diametroMaximo = 0;

        public int CalcularDiametro(ArvorePesquisaBinaria arvorePesquisaBinaria)
        {
            if (arvorePesquisaBinaria?.Raiz is null)
                return 0;

            CalcularAltura(arvorePesquisaBinaria.Raiz);

            return _diametroMaximo;
        }

        private int CalcularAltura(NoArvore? noAtual)
        {
            if (noAtual is null)
                return 0;

            int alturaEsquerda = CalcularAltura(noAtual.NoEsquerdo);
            int alturaDireita = CalcularAltura(noAtual.NoDireito);

            int diametroNoAtual = alturaEsquerda + alturaDireita + 1;
            if (diametroNoAtual > _diametroMaximo)
                _diametroMaximo = diametroNoAtual;

            return Math.Max(alturaEsquerda, alturaDireita) + 1;
        }
    }
}
