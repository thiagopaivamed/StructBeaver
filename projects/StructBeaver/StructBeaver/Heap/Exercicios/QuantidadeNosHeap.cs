namespace StructBeaver.Heap.Exercicios
{
    public class QuantidadeNosHeap
    {
        public (int Minimo, int Maximo) PegarQuantidadeDeNosPossiveis(int altura)
        {
            if (altura < 0)
                throw new ArgumentOutOfRangeException(nameof(altura), "Altura não pode ser negativa.");

            int minimo = (int)Math.Pow(2, altura);
            int maximo = (int)Math.Pow(2, altura + 1) - 1;

            return (minimo, maximo);
        }
    }
}