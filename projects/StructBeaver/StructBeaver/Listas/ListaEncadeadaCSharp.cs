namespace StructBeaver.Listas
{
    public class ListaEncadeadaCSharp
    {
        private List<int> numeros;

        public ListaEncadeadaCSharp()
            => numeros = new List<int>();        

        public void Adicionar(int valor)
            => numeros.Add(valor);

        public bool Remover(int valor)
            => numeros.Remove(valor);
    }
}