namespace StructBeaver.Recursividade
{
    public class Fatorial
    {
        public int CalcularFatorial(int numero)
        {
            if (numero < 0)
                return -1;

            else if (numero is 0 or 1)
                return 1;

            else
                return numero * CalcularFatorial(numero - 1);
        }
    }
}