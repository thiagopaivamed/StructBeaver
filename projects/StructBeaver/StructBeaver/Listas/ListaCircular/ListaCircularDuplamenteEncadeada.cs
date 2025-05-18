namespace StructBeaver.Listas.ListaCircular
{
    public class ListaCircularDuplamenteEncadeada
    {
        public NoCircular? PrimeiroNo;

        public NoCircular? PegarPrimeiroNo() => PrimeiroNo;

        public NoCircular AdicionarNoInicio(int valor)
        {
            NoCircular novoNo = new(valor);

            if (PrimeiroNo is null)            
                PrimeiroNo = novoNo;
            
            else
            {
                NoCircular? ultimoNo = PrimeiroNo.Anterior;

                novoNo.Proximo = PrimeiroNo;
                novoNo.Anterior = ultimoNo;

                PrimeiroNo.Anterior = novoNo;
                ultimoNo!.Proximo = novoNo;

                PrimeiroNo = novoNo;
            }

            return novoNo;  
        }

        public NoCircular AdicionarNoFim(int valor)
        {
            NoCircular novoNo = new (valor);

            if (PrimeiroNo is null)            
                PrimeiroNo = novoNo;
            
            else
            {
                NoCircular? ultimoNo = PrimeiroNo.Anterior;

                novoNo.Proximo = PrimeiroNo;
                novoNo.Anterior = ultimoNo;

                ultimoNo!.Proximo = novoNo;
                PrimeiroNo.Anterior = novoNo;
            }

            return novoNo;  
        }

        public NoCircular? Remover(int valor)
        {
            if (PrimeiroNo is null)
                return null;

            NoCircular? noAtual = PrimeiroNo;

            do
            {
                if (noAtual!.Valor == valor)
                {
                    if (noAtual.Proximo == noAtual)                    
                        PrimeiroNo = null;
                    
                    else
                    {
                        noAtual.Anterior!.Proximo = noAtual.Proximo;
                        noAtual.Proximo!.Anterior = noAtual.Anterior;

                        if (noAtual == PrimeiroNo)
                            PrimeiroNo = noAtual.Proximo;
                    }

                    noAtual.Proximo = null!;
                    noAtual.Anterior = null!;

                    return noAtual; 
                }

                noAtual = noAtual.Proximo;
            } while (noAtual != PrimeiroNo);

            return null;  
        }
    }
}