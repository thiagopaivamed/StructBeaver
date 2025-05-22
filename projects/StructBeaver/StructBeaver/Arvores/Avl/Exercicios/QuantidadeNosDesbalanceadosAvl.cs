namespace StructBeaver.Arvores.Avl.Exercicios
{
    public class QuantidadeNosDesbalanceadosAvl
    {
        public int ContarNosDesbalanceados(ArvoreAvl arvore)
        {
            if (arvore?.RaizAvl is null)
                return 0;

            return ContarNosDesbalanceados(arvore.RaizAvl);
        }

        private int ContarNosDesbalanceados(NoAvl? noAtual)
        {
            if (noAtual is null)
                return 0;

            int alturaEsquerda = noAtual.NoEsquerdo?.Altura ?? 0;
            int alturaDireita = noAtual.NoDireito?.Altura ?? 0;

            int fatorBalanceamento = alturaEsquerda - alturaDireita;

            int quantidadeNosDesbalanceados = 0;

            if (Math.Abs(fatorBalanceamento) > 1)
                quantidadeNosDesbalanceados = 1;

            quantidadeNosDesbalanceados = quantidadeNosDesbalanceados + ContarNosDesbalanceados(noAtual.NoEsquerdo);
            quantidadeNosDesbalanceados = quantidadeNosDesbalanceados + ContarNosDesbalanceados(noAtual.NoDireito);

            return quantidadeNosDesbalanceados;
        }
    }
}