namespace StructBeaver.Listas
{
    public class ListaEncadeada
    {
        private No primeiroNo;

        public ListaEncadeada()
            => primeiroNo = null;

        public No AdicionarInicio(int valor)
        {
            No novoNo = new No(valor);
            novoNo.proximo = primeiroNo;
            primeiroNo = novoNo;

            return primeiroNo;
        }

        public No AdicionarFim(int valor)
        {
            No novoNo = new No(valor);

            if (primeiroNo is null)
            {
                primeiroNo = novoNo;
                return novoNo;
            }

            No noAtual = primeiroNo;

            while (noAtual.proximo is not null)
                noAtual = noAtual.proximo;

            noAtual.proximo = novoNo;

            return novoNo;
        }

        public No RemoverInicio()
        {
            if (primeiroNo is null)
                return null;

            No noRemovido = primeiroNo;
            primeiroNo = primeiroNo.proximo;
            noRemovido.proximo = null;
            return noRemovido;
        }

        public No RemoverFim()
        {
            if (primeiroNo is null)
                return null;

            if (primeiroNo.proximo is null)
            {
                No noUnico = primeiroNo;
                primeiroNo = null;
                return noUnico;
            }

            No noAtual = primeiroNo;

            while (noAtual.proximo.proximo is not null)
                noAtual = noAtual.proximo;

            No noRemovido = noAtual.proximo;
            noAtual.proximo = null;
            return noRemovido;
        }

        public No RemoverNo(int posicao)
        {
            if (posicao < 0 || primeiroNo is null)
                return null;

            if (posicao == 0)
                return RemoverInicio();

            No noAtual = primeiroNo;
            int indice = 0;

            while (noAtual.proximo is not null && indice < posicao - 1)
            {
                noAtual = noAtual.proximo;
                indice = indice + 1;
            }

            if (noAtual.proximo is null)
                return null;

            No noRemovido = noAtual.proximo;
            noAtual.proximo = noRemovido.proximo;
            noRemovido.proximo = null;

            return noRemovido;
        }

        public No Pesquisar(int valor)
        {
            No noAtual = primeiroNo;

            while (noAtual is not null)
            {
                if (noAtual.valor == valor)
                    return noAtual;

                noAtual = noAtual.proximo;
            }

            return null;
        }

        public int Size()
        {
            int quantidadeNos = 0;

            No noAtual = primeiroNo;

            while (noAtual is not null)
            {
                noAtual = noAtual.proximo;
                quantidadeNos = quantidadeNos + 1;
            }

            return quantidadeNos;
        }

        public bool IsEmpty()
            => primeiroNo is null;
    }
}
