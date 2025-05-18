namespace StructBeaver.Recursividade.Exercicios
{
    public class PalindromoRecursivo
    {
        public bool IsPalindromo(string palavra, int inicio, int fim)
        {
            if (inicio >= fim)
                return true;

            if (palavra[inicio] != palavra[fim])
                return false;

            return IsPalindromo(palavra, inicio + 1, fim - 1);
        }
    }
}