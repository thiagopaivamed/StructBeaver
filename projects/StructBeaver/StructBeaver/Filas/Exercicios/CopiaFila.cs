namespace StructBeaver.Filas.Exercicios
{
    public class CopiaFila
    {
        public Fila CopiarDados(Fila fila)
        {
            Fila filaCopia = new Fila();

            while(!fila.IsEmpty())
                filaCopia.Enqueue(fila.Dequeue());

            return filaCopia;
        }
    }
}
