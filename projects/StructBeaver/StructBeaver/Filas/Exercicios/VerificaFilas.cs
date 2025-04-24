namespace StructBeaver.Filas.Exercicios
{
    public class VerificaFilas
    {
        public bool VerificarFilasPorOrdemValores(Fila fila1, Fila fila2)
        {
            while(!fila1.IsEmpty() && !fila2.IsEmpty())
            {
                int valorFila1 = fila1.Dequeue();
                int valorFila2 = fila2.Dequeue();

                if(valorFila1 != valorFila2)
                    return false;
            }
            return true;
        }
    }
}
