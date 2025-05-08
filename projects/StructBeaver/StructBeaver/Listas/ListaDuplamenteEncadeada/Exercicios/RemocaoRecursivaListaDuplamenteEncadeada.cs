namespace StructBeaver.Listas.ListaDuplamenteEncadeada.Exercicios
{
    public class RemocaoRecursivaListaDuplamenteEncadeada
    {
        public NoDuplamenteEncadeado Remover(ListaDuplamenteEncadeada lista, int valor)
        {
            NoDuplamenteEncadeado primeiroNo = lista.PegarPrimeiroNo();

            return RemoverRecursivo(lista, primeiroNo, valor);
        }

        private NoDuplamenteEncadeado RemoverRecursivo(ListaDuplamenteEncadeada lista, NoDuplamenteEncadeado noAtual, int valor)
        {
            if (noAtual is null)
                return null;

            if (noAtual.Valor == valor)
            {
                NoDuplamenteEncadeado primeiroNo = lista.PegarPrimeiroNo();
                NoDuplamenteEncadeado ultimoNo = lista.PegarUltimoNo();

                if (noAtual == primeiroNo)
                {
                    if (noAtual.Proximo is null)
                    {
                        lista.PrimeiroNo = null;
                        lista.UltimoNo = null;
                    }

                    else
                    {
                        lista.PrimeiroNo = noAtual.Proximo;
                        noAtual.Proximo.Anterior = null;
                    }
                }
                
                else if (noAtual == ultimoNo)
                {
                    if (noAtual.Anterior is null)
                    {
                        lista.PrimeiroNo = null;
                        lista.UltimoNo = null;
                    }

                    else
                    {
                        lista.UltimoNo = noAtual.Anterior;
                        noAtual.Anterior.Proximo = null;
                    }
                }
                
                else
                {
                    noAtual.Anterior!.Proximo = noAtual.Proximo;
                    noAtual.Proximo!.Anterior = noAtual.Anterior;
                }

                noAtual.Proximo = null;
                noAtual.Anterior = null;

                return noAtual; 
            }

            return RemoverRecursivo(lista, noAtual.Proximo, valor);
        }
    }
}