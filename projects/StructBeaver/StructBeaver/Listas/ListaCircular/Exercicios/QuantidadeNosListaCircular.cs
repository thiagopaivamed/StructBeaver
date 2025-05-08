namespace StructBeaver.Listas.ListaCircular.Exercicios
{
    public class QuantidadeNosListaCircular
    {
        public int ContarQuantidadeNos(ListaCircularDuplamenteEncadeada listaCircularDuplamenteEncadeada)
        {
            NoCircular noAtual = listaCircularDuplamenteEncadeada.PrimeiroNo;

            if(noAtual is null)
                return 0;

            NoCircular primeiroNo = noAtual;
            int quantidadeNos = 0;

            while (noAtual.Proximo != primeiroNo)
            {
                quantidadeNos = quantidadeNos + 1;
                noAtual = noAtual.Proximo;
            }

            return quantidadeNos + 1;
        }
    }
}