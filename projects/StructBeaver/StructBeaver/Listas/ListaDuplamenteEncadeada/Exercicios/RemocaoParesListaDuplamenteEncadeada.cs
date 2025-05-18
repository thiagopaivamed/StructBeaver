namespace StructBeaver.Listas.ListaDuplamenteEncadeada.Exercicios
{
    public class RemocaoParesListaDuplamenteEncadeada
    {
        public ListaDuplamenteEncadeada Remover(ListaDuplamenteEncadeada listaDuplamenteEncadeada)
        {
            NoDuplamenteEncadeado? noAtual = listaDuplamenteEncadeada.PegarPrimeiroNo();

            while (noAtual is not null)
            {
                NoDuplamenteEncadeado? proximoNo = noAtual.Proximo;

                if (noAtual.Valor % 2 == 0)
                    listaDuplamenteEncadeada.Remover(noAtual.Valor);

                noAtual = proximoNo;
            }

            return listaDuplamenteEncadeada;
        }
    }
}