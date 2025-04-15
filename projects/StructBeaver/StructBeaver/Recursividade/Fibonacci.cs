namespace StructBeaver.Recursividade
{
    public class Fibonacci
    {
        public int CalcularFibonacci(int numeroSequencia)
        {
            if (numeroSequencia < 2)
                return numeroSequencia;

            return CalcularFibonacci(numeroSequencia - 1) + CalcularFibonacci(numeroSequencia - 2);
        }
    }
}
