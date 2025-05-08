namespace StructBeaver.Listas.ListaDuplamenteEncadeada
{
    public class NoDuplamenteEncadeado
    {
        public int Valor;
        public NoDuplamenteEncadeado? Proximo;
        public NoDuplamenteEncadeado? Anterior;

        public NoDuplamenteEncadeado(int valor)
        {
            Valor = valor;
            Proximo = null;
            Anterior = null;
        }
    }
}