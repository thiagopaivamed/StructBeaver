namespace StructBeaver.Listas.ListaCircular.Exercicios
{
    public class RotacaoListaCircular
    {
        public ListaCircularDuplamenteEncadeada Rotacionar(ListaCircularDuplamenteEncadeada listaCircular, int quantidadeRotacoes)
        {
            NoCircular noAtual = listaCircular.PrimeiroNo;

            for (int i = 0; i < quantidadeRotacoes; i++)
                noAtual = noAtual.Proximo;            

            listaCircular.PrimeiroNo = noAtual;

            return listaCircular;
        }
    }
}
