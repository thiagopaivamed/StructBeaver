namespace StructBeaver.Vetores.Exercicios
{
    public class MaiorMenorNumero
    {
        public string PegarMaiorMenor(int[] vetor)
        {
            int maior = vetor[0];
            int menor = vetor[0];

            for (int indice = 0; indice < vetor.Length; indice++)
            {
                if (vetor[indice] > maior)
                    maior = vetor[indice];

                else if (vetor[indice] < menor)
                    menor = vetor[indice];
            }

            return $"{maior} {menor}";
        }
    }
}