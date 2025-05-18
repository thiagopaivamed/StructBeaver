namespace StructBeaver.Pilhas.Exercicios
{
    public class CopiaPilha
    {
        public Pilha PegarPilhaCopiada(Pilha pilha)
        {
            Pilha pilhaCopiada = new();
            int quantidadeElementos = pilha.Tamanho();

            for (int i = 0; i < quantidadeElementos; i++)
                pilhaCopiada.Push(pilha.Pop());

            return pilhaCopiada;
        }
    }
}