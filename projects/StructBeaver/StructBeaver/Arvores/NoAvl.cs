namespace StructBeaver.Arvores
{
    public class NoAvl(int valor)
    {
        public int Valor = valor;
        public NoAvl? NoEsquerdo;
        public NoAvl? NoDireito;
        public int Altura = 1;
    }
}
