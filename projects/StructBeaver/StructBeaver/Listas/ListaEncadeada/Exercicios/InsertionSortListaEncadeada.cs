namespace StructBeaver.Listas.ListaEncadeada.Exercicios
{
    public class InsertionSortListaEncadeada
    {
        public ListaEncadeada Ordenar(ListaEncadeada listaParaOrdenar)
        {
            ListaEncadeada listaOrdenada = new ListaEncadeada();
            No? noAtual = listaParaOrdenar.PrimeiroNo;

            while (noAtual != null)
            {
                No novoNo = new No(noAtual.Valor);

                if (listaOrdenada.PrimeiroNo is null || novoNo.Valor < listaOrdenada.PrimeiroNo.Valor)
                {
                    novoNo.Proximo = listaOrdenada.PrimeiroNo;
                    listaOrdenada.PrimeiroNo = novoNo;
                }

                else
                {
                    No noBusca = listaOrdenada.PrimeiroNo;

                    while (noBusca.Proximo != null && noBusca.Proximo.Valor < novoNo.Valor)
                        noBusca = noBusca.Proximo;

                    novoNo.Proximo = noBusca.Proximo;
                    noBusca.Proximo = novoNo;
                }

                noAtual = noAtual.Proximo;
            }

            return listaOrdenada;
        }
    }
}