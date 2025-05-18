namespace StructBeaver.Listas.ListaEncadeada
{
    public class ListaEncadeada
    {
        public No? PrimeiroNo;        

        public No? PegarPrimeiroNo() => PrimeiroNo;

        public No AdicionarNoInicio(int valor)
        {
            No novoNo = new(valor);
            novoNo.Proximo = PrimeiroNo;
            PrimeiroNo = novoNo;

            return PrimeiroNo;
        }

        public No AdicionarNoFim(int valor)
        {
            No novoNo = new (valor);

            if (PrimeiroNo is null)
            {
                PrimeiroNo = novoNo;
                return novoNo;
            }

            No noAtual = PrimeiroNo;

            while (noAtual.Proximo is not null)
                noAtual = noAtual.Proximo;

            noAtual.Proximo = novoNo;

            return novoNo;
        }

        public No? RemoverNoInicio()
        {
            if (PrimeiroNo is null)
                return null;

            No noRemovido = PrimeiroNo;
            PrimeiroNo = PrimeiroNo.Proximo;
            noRemovido.Proximo = null;
            return noRemovido;
        }

        public No? RemoverNoFim()
        {
            if (PrimeiroNo is null)
                return null;

            if (PrimeiroNo.Proximo is null)
            {
                No noUnico = PrimeiroNo;
                PrimeiroNo = null;
                return noUnico;
            }

            No? noAtual = PrimeiroNo;

            while (noAtual?.Proximo?.Proximo is not null)
                noAtual = noAtual.Proximo;

            No? noRemovido = noAtual?.Proximo;

            if(noAtual is not null)
                noAtual.Proximo = null;

            return noRemovido;
        }

        public No? RemoverNo(int posicao)
        {
            if (posicao < 0 || PrimeiroNo is null)
                return null;

            if (posicao == 0)
                return RemoverNoInicio();

            No noAtual = PrimeiroNo;
            int indice = 0;

            while (noAtual.Proximo is not null && indice < posicao - 1)
            {
                noAtual = noAtual.Proximo;
                indice = indice + 1;
            }

            if (noAtual.Proximo is null)
                return null;

            No noRemovido = noAtual.Proximo;
            noAtual.Proximo = noRemovido.Proximo;
            noRemovido.Proximo = null;

            return noRemovido;
        }

        public No? Pesquisar(int valor)
        {
            No? noAtual = PrimeiroNo;

            while (noAtual is not null)
            {
                if (noAtual.Valor == valor)
                    return noAtual;

                noAtual = noAtual.Proximo;
            }

            return null;
        }

        public int Size()
        {
            int quantidadeNos = 0;

            No? noAtual = PrimeiroNo;

            while (noAtual is not null)
            {
                noAtual = noAtual.Proximo;
                quantidadeNos = quantidadeNos + 1;
            }

            return quantidadeNos;
        }
        public bool IsEmpty()
            => PrimeiroNo is null;
    }
}