namespace StructBeaver.Listas.ListaEncadeada.Exercicios
{
    public class PesquisaRecursivaListaEncadeada
    {
        public bool Pesquisar(ListaEncadeada listaEncadeada, int valorProcurado)
        {
            No noAtual = listaEncadeada.PegarPrimeiroNo();

            return PesquisarRecursivo(noAtual, valorProcurado);
        }

        private bool PesquisarRecursivo(No noAtual, int valorProcurado)
        {
            if (noAtual is null)
                return false;

            if (noAtual.Valor == valorProcurado)
                return true;

            return PesquisarRecursivo(noAtual.Proximo, valorProcurado);
        }
    }
}