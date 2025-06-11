namespace StructBeaver.Heap.Exercicios
{
    public class DoisMaioresComHeap
    {
        public (int? maior, int? segundoMaior) PegarDoisMaiores(int[] array)
        {
            if (array is null || array.Length == 0)
                return (null, null);

            MaxHeap heap = new ();

            foreach (int valor in array)            
                heap.Inserir(valor);            

            int? maior = heap.Tamanho > 0 ? heap.Remover() : null;
            int? segundoMaior = heap.Tamanho > 0 ? heap.Remover() : null;

            return (maior, segundoMaior);
        }
    }
}