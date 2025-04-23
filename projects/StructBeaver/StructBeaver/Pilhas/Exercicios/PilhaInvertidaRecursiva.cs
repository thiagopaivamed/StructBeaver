namespace StructBeaver.Pilhas.Exercicios
{
    public class PilhaInvertidaRecursiva
    {
        public Pilha InverterPilha(Pilha pilha)
        {
            if(pilha.IsEmpty())
                return pilha;

            int elemento = pilha.Pop();

            InverterPilha(pilha);

            pilha.Push(elemento);

            return pilha;
        }
    }
}
