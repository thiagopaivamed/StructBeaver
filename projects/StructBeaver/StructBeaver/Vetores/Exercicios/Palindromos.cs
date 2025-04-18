namespace StructBeaver.Vetores.Exercicios
{
    public class Palindromos
    {
        public bool IsPalindromo(string palavra)
        {
            int inicio = 0;
            int fim = palavra.Length - 1;

            while (inicio < fim)
            {
                if (palavra[inicio] != palavra[fim])
                    return false;

                inicio = inicio + 1;
                fim = fim - 1;
            }

            return true;
        }
    }
}
