namespace StructBeaver.Arvores.Avl.Exercicios
{
    public class MenorValorAvl
    {
        public int? PegarMenorValor(ArvoreAvl arvore)
        {
            if (arvore?.RaizAvl is null)
                return null;

            NoAvl noAtual = arvore.RaizAvl;

            while (noAtual.NoEsquerdo is not null)
                noAtual = noAtual.NoEsquerdo;

            return noAtual.Valor;
        }
    }
}