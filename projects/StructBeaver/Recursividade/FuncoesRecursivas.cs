namespace Recursividade
{
    public class FuncoesRecursivas
    {
        public int Fatorial(int numero)
        {
            if (numero < 0)
                return -1;

            else if (numero is 0 or 1)
                return 1;

            else
                return numero * Fatorial(numero - 1);
        }

        public int Fibonacci(int numeroSequencia)
        {
            if (numeroSequencia < 2)
                return numeroSequencia;

            else
                return Fibonacci(numeroSequencia - 1) + Fibonacci(numeroSequencia - 2);
        }
    }
}
