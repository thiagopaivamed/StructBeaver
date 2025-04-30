namespace StructBeaver.Listas
{
    public class ListaDuplamenteEncadeada
    {
        public class No
        {
            public int Valor;
            public No? Proximo;
            public No? Anterior;

            public No(int valor)
            {
                Valor = valor;
                Proximo = null;
                Anterior = null;
            }
        }

        private No? primeiroNo;
        private No? ultimoNo;

        public No AdicionarNoInicio(int valor)
        {
            No novoNo = new No(valor);

            if (primeiroNo == null)
            {
                novoNo.Proximo = null;
                novoNo.Anterior = null;

                primeiroNo = novoNo;
                ultimoNo = novoNo;
            }
            else
            {
                novoNo.Proximo = primeiroNo;
                novoNo.Anterior = null;

                primeiroNo.Anterior = novoNo;
                primeiroNo = novoNo;
            }

            return novoNo;
        }

        public No AdicionarNoFinal(int valor)
        {
            No novoNo = new No(valor);

            if (ultimoNo == null)
            {
                novoNo.Proximo = null;
                novoNo.Anterior = null;

                primeiroNo = novoNo;
                ultimoNo = novoNo;
            }
            else
            {
                novoNo.Anterior = ultimoNo;
                novoNo.Proximo = null;

                ultimoNo.Proximo = novoNo;
                ultimoNo = novoNo;
            }

            return novoNo;
        }

        public No? Remover(int valor)
        {
            No? noAtual = primeiroNo;

            while (noAtual != null)
            {
                if (noAtual.Valor == valor)
                {
                    if (noAtual == primeiroNo)
                    {
                        primeiroNo = primeiroNo.Proximo;

                        if (primeiroNo != null)
                            primeiroNo.Anterior = null;
                        else
                            ultimoNo = null;
                    }
                    else if (noAtual == ultimoNo)
                    {
                        ultimoNo = ultimoNo.Anterior;

                        if (ultimoNo != null)
                            ultimoNo.Proximo = null;
                        else
                            primeiroNo = null;
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
