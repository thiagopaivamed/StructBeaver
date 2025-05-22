namespace StructBeaver.Arvores.ArvoreBinaria.Exercicios
{
    public class EspelhamentoArvoreBinaria
    {
        public ArvoreBinaria? Espelhar(ArvoreBinaria arvoreBinaria)
        {
            if (arvoreBinaria?.Raiz is null)
                return null;

            NoArvore? raiz = EspelharRecursivo(arvoreBinaria.Raiz);

            return new ArvoreBinaria(raiz!);
        }

        private NoArvore? EspelharRecursivo(NoArvore noAtual)
        {
            if (noAtual is null)
                return null;

            NoArvore novoNo = new NoArvore(noAtual.Valor);
            novoNo.NoEsquerdo = EspelharRecursivo(noAtual.NoDireito!);
            novoNo.NoDireito = EspelharRecursivo(noAtual.NoEsquerdo!);

            return novoNo;
        }
    }
}