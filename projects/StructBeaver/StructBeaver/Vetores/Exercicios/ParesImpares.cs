namespace StructBeaver.Vetores.Exercicios
{
    public class ParesImpares
    {
        public string ContarParesImpares(int[] vetor)
        {
            int pares = 0;
            int impares = 0;

            for (int indice = 0; indice < vetor.Length; indice++)
            {
                if (vetor[indice] % 2 == 0)
                    pares = pares + 1;
                else
                    impares = impares + 1;
            }

            return $"{pares} {impares}";
        }
    }
}
