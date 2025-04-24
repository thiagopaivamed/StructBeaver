namespace StructBeaver.Filas.Exercicios
{
    public class MediaValoresFila
    {
        public double CalcularMedia(Fila fila)
        {
            int totalValores = 0;
            double somaValores = 0;

            while(!fila.IsEmpty())
            {
                double valor = fila.Dequeue();
                totalValores = totalValores + 1;
                somaValores = somaValores + valor;
            }

            return somaValores / totalValores;
        }
    }
}
