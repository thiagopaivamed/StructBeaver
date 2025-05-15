namespace StructBeaver.Arvores
{
    public class NoAvl
    {
        public int Valor;
        public NoAvl? NoEsquerdo;
        public NoAvl? NoDireito;
        public int Altura;

        public NoAvl(int valor)
        {
            Valor = valor;
            Altura = 1;
        }
    }
}
