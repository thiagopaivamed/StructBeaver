namespace StructBeaver.Listas
{
    public class ListaCircularDuplamenteEncadeada
    {
        public class No
        {
            public int Valor;
            public No Proximo;
            public No Anterior;

            public No(int valor)
            {
                Valor = valor;
                Proximo = this;
                Anterior = this;
            }
        }

        public No? primeiroNo;

        public No? AdicionarNoInicio(int valor)
        {
            No novoNo = new No(valor);

            if (primeiroNo == null)            
                primeiroNo = novoNo;
            
            else
            {
                No ultimoNo = primeiroNo.Anterior;

                novoNo.Proximo = primeiroNo;
                novoNo.Anterior = ultimoNo;

                primeiroNo.Anterior = novoNo;
                ultimoNo.Proximo = novoNo;

                primeiroNo = novoNo;
            }

            return novoNo;  
        }

        public No? AdicionarNoFim(int valor)
        {
            No novoNo = new No(valor);

            if (primeiroNo == null)            
                primeiroNo = novoNo;
            
            else
            {
                No ultimoNo = primeiroNo.Anterior;

                novoNo.Proximo = primeiroNo;
                novoNo.Anterior = ultimoNo;

                ultimoNo.Proximo = novoNo;
                primeiroNo.Anterior = novoNo;
            }

            return novoNo;  
        }

        public No? Remover(int valor)
        {
            if (primeiroNo == null)
                return null;

            No noAtual = primeiroNo;

            do
            {
                if (noAtual.Valor == valor)
                {
                    if (noAtual.Proximo == noAtual)                    
                        primeiroNo = null;
                    
                    else
                    {
                        noAtual.Anterior.Proximo = noAtual.Proximo;
                        noAtual.Proximo.Anterior = noAtual.Anterior;

                        if (noAtual == primeiroNo)
                            primeiroNo = noAtual.Proximo;
                    }

                    noAtual.Proximo = null;
                    noAtual.Anterior = null;

                    return noAtual; 
                }

                noAtual = noAtual.Proximo;
            } while (noAtual != primeiroNo);

            return null;  
        }
    }
}