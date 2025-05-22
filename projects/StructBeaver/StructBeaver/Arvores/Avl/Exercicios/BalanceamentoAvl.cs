namespace StructBeaver.Arvores.Avl.Exercicios
{
    public class BalanceamentoAvl
    {
        public bool EhBalanceada(ArvoreAvl arvore)
        {
            if (arvore?.RaizAvl is null)
                return true;

            return VerificarBalanceamento(arvore.RaizAvl);
        }

        private bool VerificarBalanceamento(NoAvl? noAtual)
        {
            if (noAtual is null)
                return true;

            int alturaEsquerda = noAtual.NoEsquerdo?.Altura ?? 0;
            int alturaDireita = noAtual.NoDireito?.Altura ?? 0;

            int fatorBalanceamento = alturaEsquerda - alturaDireita;

            if (Math.Abs(fatorBalanceamento) > 1)
                return false;

            return VerificarBalanceamento(noAtual.NoEsquerdo) && VerificarBalanceamento(noAtual.NoDireito);
        }
    }
}