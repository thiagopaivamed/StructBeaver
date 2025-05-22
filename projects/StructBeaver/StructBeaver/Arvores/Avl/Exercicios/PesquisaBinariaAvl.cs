namespace StructBeaver.Arvores.Avl.Exercicios
{
    public class PesquisaBinariaAvl
    {
        public NoAvl? Pesquisar(ArvoreAvl arvoreAvl, int valorProcurado)
        {
            if (arvoreAvl?.RaizAvl is null)
                return null;

            NoAvl raiz = arvoreAvl.RaizAvl;

            if (raiz.Valor == valorProcurado)
                return raiz;

            return Pesquisar(raiz, valorProcurado);
        }

        private NoAvl? Pesquisar(NoAvl? noAtual, int valorProcurado)
        {
            if (noAtual is null)
                return null;

            if (noAtual.Valor == valorProcurado)
                return noAtual;

            if (valorProcurado < noAtual.Valor)
                return Pesquisar(noAtual.NoEsquerdo, valorProcurado);

            return Pesquisar(noAtual.NoDireito, valorProcurado);
        }
    }
}
