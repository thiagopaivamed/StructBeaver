namespace StructBeaver.Listas.ListaDuplamenteEncadeada.Exercicios
{
    public class InversaoRecursivaListaDuplamenteEncadeada
    {
        public ListaDuplamenteEncadeada Inverter(ListaDuplamenteEncadeada listaDuplamenteEncadeada)
        {
            NoDuplamenteEncadeado? primeiroNo = listaDuplamenteEncadeada.PegarPrimeiroNo();

            if (primeiroNo is null)
                return listaDuplamenteEncadeada;

            InverterRecursivo(primeiroNo, listaDuplamenteEncadeada);

            NoDuplamenteEncadeado? noTemporario = listaDuplamenteEncadeada.PrimeiroNo;
            listaDuplamenteEncadeada.PrimeiroNo = listaDuplamenteEncadeada.UltimoNo;
            listaDuplamenteEncadeada.UltimoNo = noTemporario;

            return listaDuplamenteEncadeada;
        }

        private ListaDuplamenteEncadeada InverterRecursivo(NoDuplamenteEncadeado noAtual, ListaDuplamenteEncadeada listaDuplamenteEncadeada)
        {
            NoDuplamenteEncadeado? noTemporario = noAtual.Proximo;
            noAtual.Proximo = noAtual.Anterior;
            noAtual.Anterior = noTemporario;

            if (noAtual.Anterior is null)
                return listaDuplamenteEncadeada;

            return InverterRecursivo(noAtual.Anterior, listaDuplamenteEncadeada);
        }
    }
}