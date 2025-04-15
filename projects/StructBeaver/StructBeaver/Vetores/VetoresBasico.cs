namespace StructBeaver.Vetores
{
    public class VetoresBasico
    {
        public int[] AdicionarElemento(int valorAdicionado)
        {
            int[] vetorAnterior = { 9, 2, 5, 1, 0, 7, 10, 3, 8, 7 };

            int[] vetorNovo = new int[vetorAnterior.Length + 1];

            Array.Copy(vetorAnterior, vetorNovo, vetorAnterior.Length);

            vetorNovo[vetorNovo.Length - 1] = valorAdicionado;

            vetorAnterior = vetorNovo;

            return vetorAnterior;
        }
    }
}
