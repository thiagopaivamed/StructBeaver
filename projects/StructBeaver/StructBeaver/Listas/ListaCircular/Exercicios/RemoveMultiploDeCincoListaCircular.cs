namespace StructBeaver.Listas.ListaCircular.Exercicios
{
    public class RemoveMultiploDeCincoListaCircular
    {
        public ListaCircularDuplamenteEncadeada RemoverMultiploDeCinco(ListaCircularDuplamenteEncadeada listaCircular)
        {
            NoCircular? noAtual = listaCircular.PrimeiroNo;
            NoCircular? primeiroNo = noAtual;

            while (noAtual!.Proximo is not null && (noAtual.Proximo != primeiroNo || noAtual.Valor % 5 == 0))
            {
                if (noAtual.Valor % 5 == 0)
                {
                    NoCircular proximoNo = noAtual.Proximo;
                    listaCircular.Remover(noAtual.Valor);

                    if (noAtual.Valor == primeiroNo!.Valor)
                        primeiroNo = proximoNo;

                    noAtual = proximoNo;
                }

                else
                    noAtual = noAtual.Proximo;

            }

            return listaCircular;
        }
    }
}