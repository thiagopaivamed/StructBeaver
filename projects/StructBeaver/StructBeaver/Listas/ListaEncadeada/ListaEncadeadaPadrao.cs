namespace StructBeaver.Listas.ListaEncadeada
{
    public class ListaEncadeadaPadrao
    {
        private List<int> Numeros;

        public ListaEncadeadaPadrao()
            => Numeros = new();        

        public void Adicionar(int valor)
            => Numeros.Add(valor);

        public bool Remover(int valor)
            => Numeros.Remove(valor);
    }
}