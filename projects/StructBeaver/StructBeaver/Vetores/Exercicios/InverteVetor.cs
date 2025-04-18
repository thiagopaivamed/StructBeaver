namespace StructBeaver.Vetores.Exercicios
{
    public class InverteVetor
    {
        public int[] Inverter(int[] vetor)
        {
            int[] vetorInvertido = new int[vetor.Length];
            int indiceVetorInvertido = 0;

            for (int indice = vetor.Length - 1; indice >= 0; indice--)
            {
                vetorInvertido[indiceVetorInvertido] = vetor[indice];
                indiceVetorInvertido = indiceVetorInvertido + 1;
            }

            return vetorInvertido;
        }
    }
}
