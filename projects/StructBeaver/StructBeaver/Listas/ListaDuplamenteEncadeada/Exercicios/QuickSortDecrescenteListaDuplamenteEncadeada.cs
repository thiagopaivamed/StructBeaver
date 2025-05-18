namespace StructBeaver.Listas.ListaDuplamenteEncadeada.Exercicios
{
    public class QuickSortDecrescenteListaDuplamenteEncadeada
    {
        public ListaDuplamenteEncadeada QuickSortDecrescente(ListaDuplamenteEncadeada listaParaOrdenacao)
        {
            NoDuplamenteEncadeado? primeiroNo = listaParaOrdenacao.PegarPrimeiroNo();

            if (primeiroNo is null)
                return listaParaOrdenacao;

            NoDuplamenteEncadeado? ultimoNo = listaParaOrdenacao.PegarUltimoNo();

            OrdenarComQuickSort(primeiroNo, ultimoNo, listaParaOrdenacao);

            return listaParaOrdenacao;
        }

        private void OrdenarComQuickSort(NoDuplamenteEncadeado inicio, NoDuplamenteEncadeado? fim, ListaDuplamenteEncadeada listaParaOrdenacao)
        {
            if (inicio is null || fim is null || inicio == fim || inicio.Anterior == fim)
                return;

            NoDuplamenteEncadeado pivo = Particionar(inicio, fim)!;

            if (pivo.Anterior is not null)
                OrdenarComQuickSort(inicio, pivo.Anterior, listaParaOrdenacao);
            if (pivo.Proximo is not null)
                OrdenarComQuickSort(pivo.Proximo, fim, listaParaOrdenacao);
        }

        private NoDuplamenteEncadeado? Particionar(NoDuplamenteEncadeado inicio, NoDuplamenteEncadeado fim)
        {
            int valorPivo = fim.Valor;
            NoDuplamenteEncadeado? noMenor = inicio.Anterior;
            NoDuplamenteEncadeado noAtual = inicio;

            while (noAtual != fim)
            {
                if (noAtual.Valor >= valorPivo)
                {
                    if(noMenor is null)
                        noMenor = inicio;

                    else
                        noMenor = noMenor.Proximo;

                    Trocar(noMenor!, noAtual);
                }
                noAtual = noAtual.Proximo!;
            }

            if (noMenor is null)
                noMenor = inicio;

            else
                noMenor = noMenor.Proximo;

            Trocar(noMenor, fim);

            return noMenor;
        }

        private void Trocar(NoDuplamenteEncadeado? noA, NoDuplamenteEncadeado noB)
            => (noB.Valor, noA!.Valor) = (noA.Valor, noB.Valor);        
    }
}