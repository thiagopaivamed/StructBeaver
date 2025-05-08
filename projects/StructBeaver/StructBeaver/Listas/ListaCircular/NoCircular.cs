namespace StructBeaver.Listas.ListaCircular
{
    public class NoCircular
    {
        public int Valor;
        public NoCircular Proximo;
        public NoCircular Anterior;

        public NoCircular(int valor)
        {
            Valor = valor;
            Proximo = this;
            Anterior = this;
        }
    }
}
