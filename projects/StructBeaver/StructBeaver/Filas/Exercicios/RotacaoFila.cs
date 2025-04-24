namespace StructBeaver.Filas.Exercicios
{
    public class RotacaoFila
    {
        public Fila Rotacionar(Fila fila, int vezes)
        {
            while(vezes > 0)
            {
                int valor = fila.Dequeue();
                fila.Enqueue(valor);
                vezes = vezes - 1;
            }

            return fila;
        }
    }
}
