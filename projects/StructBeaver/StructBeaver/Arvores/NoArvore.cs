namespace StructBeaver.Arvores
{
    public class NoArvore (int valor)
    {
        public int? Valor = valor;
        public NoArvore? NoEsquerdo;
        public NoArvore? NoDireito;
    }
}
