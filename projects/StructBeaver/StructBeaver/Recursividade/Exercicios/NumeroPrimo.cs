namespace StructBeaver.Recursividade.Exercicios
{
    public class NumeroPrimo
    {
        public bool VerificarPrimo(int numero, int divisor)
        {
            if (divisor >= numero)
                return true;

            if (numero % divisor == 0)
                return false;

            return VerificarPrimo(numero, divisor + 1);
        }
    }
}