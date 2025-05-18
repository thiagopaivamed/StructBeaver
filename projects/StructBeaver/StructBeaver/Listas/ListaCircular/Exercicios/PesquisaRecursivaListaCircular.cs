namespace StructBeaver.Listas.ListaCircular.Exercicios
{
    public class PesquisaRecursivaListaCircular
    {
        public bool Pesquisar(ListaCircularDuplamenteEncadeada listaCircularDuplamenteEncadeada, int valorProcurado)
        {
            NoCircular? noAtual = listaCircularDuplamenteEncadeada.PrimeiroNo;

            if (noAtual is null) 
                return false;

            return PesquisarRecursivo(noAtual, noAtual, valorProcurado);
        }

        private bool PesquisarRecursivo(NoCircular? noAtual, NoCircular primeiroNo, int valorProcurado)
        {
            if (noAtual!.Valor == valorProcurado)
                return true;

            if(noAtual.Proximo == primeiroNo)
                return false;

            return PesquisarRecursivo(noAtual.Proximo, primeiroNo, valorProcurado);
        }
    }
}