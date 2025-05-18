namespace StructBeaver.Listas.ListaEncadeada.Exercicios
{
    public class JuncaoListasEncadeadas
    {
        public ListaEncadeada FazerMerge(ListaEncadeada lista1, ListaEncadeada lista2)
        {
            ListaEncadeada listasCombinadas = new();

            No? no1 = lista1.PegarPrimeiroNo();
            No? no2 = lista2.PegarPrimeiroNo();

            return MergeRecursivo(no1, no2, listasCombinadas);
        }

        private ListaEncadeada MergeRecursivo(No? no1, No? no2, ListaEncadeada listasCombinadas)
        {
            if (no1 is null && no2 is null)
                return listasCombinadas;

            if (no1 is not null)
                listasCombinadas.AdicionarNoFim(no1.Valor);

            if (no2 is not null)
                listasCombinadas.AdicionarNoFim(no2.Valor);

            return MergeRecursivo(no1?.Proximo, no2?.Proximo, listasCombinadas);
        }
    }
}