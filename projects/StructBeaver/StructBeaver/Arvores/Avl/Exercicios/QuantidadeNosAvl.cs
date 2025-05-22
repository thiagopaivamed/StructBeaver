namespace StructBeaver.Arvores.Avl.Exercicios
{
    public class QuantidadeNosAvl
    {
        public int ContarQuantidadeNos(ArvoreAvl arvore)
        {
            if (arvore?.RaizAvl is null)
                return 0;

            return Contar(arvore.RaizAvl);
        }

        private int Contar(NoAvl? noAtual)
        {
            if (noAtual is null)
                return 0;

            return 1 + Contar(noAtual.NoEsquerdo) + Contar(noAtual.NoDireito);
        }
    }
}
