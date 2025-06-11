---

comments: true

---

# **Exercícios de heaps**

(1) Crie uma função para transformar um heap em um array. Essa transformação deve ordenar seus elementos por prioridade.

??? abstract "Heap para array"

    ```csharp
    
    public class HeapParaArrayOrdenado
    {
        public int[] Converter(MaxHeap maxHeap)
        {
            List<int> novaHeap = new();

            while (maxHeap.Tamanho > 0)
                novaHeap.Add(maxHeap.Remover());

            return [.. novaHeap];
        }
    }
    
    ```

(2) Crie uma função para verificar se um heap é válido.

??? abstract "Heap é valido"

    ```csharp
    
    public class MaxHeapValido
    {
        public bool Validar(MaxHeap heap)
        {
            List<int> itens = [];

            while (heap.Tamanho > 0)
                itens.Add(heap.Remover());

            for (int i = 1; i < itens.Count; i++)
            {
                if (itens[i] > itens[i - 1])
                    return false;
            }

            foreach (int item in itens)
                heap.Inserir(item);

            return true;
        }
    }
    
    ```

(3) Crie uma função que retorne os 2 maiores elementos de um array usando max-heap.

??? abstract "Maiores 2 elementos com max-heap"

    ```csharp
    
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
    
    ```

(4) Crie uma função que retorne o k-sésimo maior elemento de um array usando heap.

??? abstract "K-sésimo maior elemento"

    ```csharp
    
    public class K_esimoMaiorComHeap
    {
        public int? PegarK_esimoMaior(int[] array, int k)
        {
            if (array is null || array.Length < k || k <= 0)
                return null;

            MaxHeap heap = new();

            foreach (int num in array)
                heap.Inserir(num);

            for (int i = 1; i < k; i++)
                heap.Remover();

            return heap.Peek();
        }
    }

    ```

(5) Crie uma função que retorne a quantidade mínima e máxima de nós que podem existir em um heap com altura h.

??? abstract "Mínimo e máximo de nós"

    ```csharp
    
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
    
    ```