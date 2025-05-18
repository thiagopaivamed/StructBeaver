namespace StructBeaver.Listas.ListaDuplamenteEncadeada
{
    public class NoDuplamenteEncadeado(int valor)
    {
        public int Valor = valor;
        public NoDuplamenteEncadeado? Proximo;
        public NoDuplamenteEncadeado? Anterior;        
    }
}