namespace StructBeaver.Recursividade.Exercicios
{
    public class DigitosRecursivo
    {
        public int PegarQuantidadeDigitos(int numero)
        {
            if (numero < 10)
                return 1;

            return 1 + PegarQuantidadeDigitos(numero / 10);
        }
    }
}