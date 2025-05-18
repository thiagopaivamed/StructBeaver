namespace StructBeaver.Pilhas.Exercicios
{
    public class MenorValorPilha
    {
        public int PegarMenorValor(Pilha pilha)
        {
            int quantidadeElementos = pilha.Tamanho();
            int menorElemento = pilha.Pop();

            for (int i = 0; i < quantidadeElementos - 1; i++)
            {
                int aux = pilha.Pop();
                if (aux < menorElemento)
                    menorElemento = aux;
            }

            return menorElemento;
        }
    }
}