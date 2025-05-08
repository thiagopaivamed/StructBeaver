namespace StructBeaver.Listas.ListaEncadeada
{
    public class No
    {
        public int Valor;
        public No Proximo;

        public No(int valor)
        {
            Valor = valor;
            Proximo = null;            
        }
    }
}
