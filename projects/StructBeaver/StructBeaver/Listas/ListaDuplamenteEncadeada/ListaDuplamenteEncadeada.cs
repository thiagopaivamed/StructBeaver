namespace StructBeaver.Listas.ListaDuplamenteEncadeada
{
    public class ListaDuplamenteEncadeada
    {
        public NoDuplamenteEncadeado? PrimeiroNo;

        public NoDuplamenteEncadeado? UltimoNo;

        public NoDuplamenteEncadeado? PegarPrimeiroNo() => PrimeiroNo;

        public NoDuplamenteEncadeado? PegarUltimoNo() => UltimoNo;

        public NoDuplamenteEncadeado AdicionarNoInicio(int valor)
        {
            NoDuplamenteEncadeado novoNo = new NoDuplamenteEncadeado(valor);

            if (PrimeiroNo is null)
            {
                novoNo.Proximo = null;
                novoNo.Anterior = null;

                PrimeiroNo = novoNo;
                UltimoNo = novoNo;
            }
            else
            {
                novoNo.Proximo = PrimeiroNo;
                novoNo.Anterior = null;

                PrimeiroNo.Anterior = novoNo;
                PrimeiroNo = novoNo;
            }

            return novoNo;
        }

        public NoDuplamenteEncadeado AdicionarNoFinal(int valor)
        {
            NoDuplamenteEncadeado novoNo = new(valor);

            if (UltimoNo is null)
            {
                novoNo.Proximo = null;
                novoNo.Anterior = null;

                PrimeiroNo = novoNo;
                UltimoNo = novoNo;
            }
            else
            {
                novoNo.Anterior = UltimoNo;
                novoNo.Proximo = null;

                UltimoNo.Proximo = novoNo;
                UltimoNo = novoNo;
            }

            return novoNo;
        }

        public NoDuplamenteEncadeado? Remover(int valor)
        {
            NoDuplamenteEncadeado? noAtual = PrimeiroNo;

            while (noAtual is not null)
            {
                if (noAtual.Valor == valor)
                {
                    if (noAtual == PrimeiroNo)
                    {
                        PrimeiroNo = PrimeiroNo.Proximo;

                        if (PrimeiroNo is not null)
                            PrimeiroNo.Anterior = null;
                        
                        else
                            UltimoNo = null;
                    }

                    else if (noAtual == UltimoNo)
                    {
                        UltimoNo = UltimoNo.Anterior;

                        if (UltimoNo is not null)
                            UltimoNo.Proximo = null;
                        
                        else
                            PrimeiroNo = null;
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

                noAtual = noAtual.Proximo;
            }

            return null;
        }
    }
}