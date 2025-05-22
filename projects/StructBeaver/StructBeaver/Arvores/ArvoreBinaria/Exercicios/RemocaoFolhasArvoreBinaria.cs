namespace StructBeaver.Arvores.ArvoreBinaria.Exercicios
{
    public class RemocaoFolhasArvoreBinaria
    {
        public ArvoreBinaria? RemoverFolhas(ArvoreBinaria arvoreBinaria)
        {
            if (arvoreBinaria?.Raiz is null)
                return null;

            arvoreBinaria.Raiz = Remover(arvoreBinaria.Raiz);
            return arvoreBinaria;
        }

        private NoArvore? Remover(NoArvore? noAtual)
        {
            if (noAtual is null)
                return null;

            if (noAtual.NoEsquerdo is null && noAtual.NoDireito is null)
                return null;

            noAtual.NoEsquerdo = Remover(noAtual.NoEsquerdo);
            noAtual.NoDireito = Remover(noAtual.NoDireito);

            return noAtual;
        }
    }
}