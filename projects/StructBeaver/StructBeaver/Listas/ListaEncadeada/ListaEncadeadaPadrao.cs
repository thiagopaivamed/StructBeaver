namespace StructBeaver.Listas.ListaEncadeada
{
    public class ListaEncadeadaPadrao
    {
        private List<int> numeros;

        public ListaEncadeadaPadrao()
            => numeros = new List<int>();        

        public void Adicionar(int valor)
            => numeros.Add(valor);

        public bool Remover(int valor)
            => numeros.Remove(valor);
    }
}