namespace StructBeaver.Listas.ListaDuplamenteEncadeada
{
    public class ListaDuplamenteEncadeadaPadrao
    {
        private LinkedList<int> _listaDuplamenteEncadeada;

        public ListaDuplamenteEncadeadaPadrao()        
            => _listaDuplamenteEncadeada = new();        

        public LinkedListNode<int>? PrimeiroNo => _listaDuplamenteEncadeada.First;

        public LinkedListNode<int>? UltimoNo => _listaDuplamenteEncadeada.Last;

        public LinkedListNode<int> AdicionarNoInicio(int valor)
            =>  _listaDuplamenteEncadeada.AddFirst(valor);        

        public LinkedListNode<int> AdicionarNoFinal(int valor)
            => _listaDuplamenteEncadeada.AddLast(valor);

        public void RemoverNoInicio()
            => _listaDuplamenteEncadeada.RemoveFirst();

        public void RemoverNoFinal()
            => _listaDuplamenteEncadeada.RemoveLast();

        public LinkedListNode<int>? Remover(int valor)
        {
            LinkedListNode<int>? noAtual = _listaDuplamenteEncadeada.First;
            
            while (noAtual != null)
            {
                if (noAtual.Value == valor)
                {
                    _listaDuplamenteEncadeada.Remove(noAtual);
                    return noAtual;
                }

                noAtual = noAtual.Next;
            }

            return null;
        }
    }
}