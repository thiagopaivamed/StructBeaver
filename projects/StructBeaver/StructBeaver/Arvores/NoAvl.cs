namespace StructBeaver.Arvores
{
    public class NoAvl
    {
        public int Valor;
        public NoAvl? Esquerda;
        public NoAvl? Direita;
        public int Altura;

        public NoAvl(int valor)
        {
            Valor = valor;
            Altura = 1;
        }
    }
}
