---

comments: true

---

# **Exercícios de filas**

(1) Escreva uma função que transfere todos os elementos de uma fila para outra.

??? abstract "Copiando dados"

    ```csharp
    
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

    ```

(2) Crie uma função que compare duas filas e verifique se são iguais (ordem e valores).

??? abstract "Comparação de filas"

    ```csharp
    
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
    
    ```    

(3) Dada uma fila de números, crie uma função que retorne a média dos valores.

??? abstract "Média de valores"

    ```csharp
    
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
    
    ```    

(4) Dada uma fila, crie uma função que rotacione os elementos n vezes (ex: [1,2,3] → [2,3,1]).

??? abstract "Rotacionando a fila"

    ```csharp
    
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
    
    ```

(5) Dada uma fila, use o método Merge Sort para ordenar a mesma.

??? abstract "Ordenando fila com Merge Sort"

    ```csharp
    
    public class OrdenacaoFila
    {
        public Fila Ordenar(Fila fila)
        {
            int quantidadeElementos = fila.Size();
            int[] elementosFila = new int[quantidadeElementos];

            for (int i = 0; i < quantidadeElementos; i++)
                elementosFila[i] = fila.Dequeue();

            int[] elementosOrdenados = Sort(elementosFila);

            for (int i = 0; i < quantidadeElementos; i++)
                fila.Enqueue(elementosOrdenados[i]);

            return fila;
        }

        private int[] Sort(int[] vetor)
        {
            int quantidadeElementos = vetor.Length;
            
            if (quantidadeElementos <= 1)
                return vetor;

            int meio = quantidadeElementos / 2;
            int[] vetorEsquerdo = new int[meio];
            int[] vetorDireito = new int[quantidadeElementos - meio];

            int indiceVetorEsquerdo = 0;
            int indiceVetorDireito = 0;

            for (; indiceVetorEsquerdo < quantidadeElementos; indiceVetorEsquerdo++)
            {
                if (indiceVetorEsquerdo < meio)
                    vetorEsquerdo[indiceVetorEsquerdo] = vetor[indiceVetorEsquerdo];
                else
                {
                    vetorDireito[indiceVetorDireito] = vetor[indiceVetorEsquerdo];
                    indiceVetorDireito = indiceVetorDireito + 1;
                }
            }

            vetorEsquerdo = Sort(vetorEsquerdo);
            vetorDireito = Sort(vetorDireito);
            Merge(vetor, vetorEsquerdo, vetorDireito);

            return vetor;
        }

        private void Merge(int[] vetor, int[] vetorEsquerdo, int[] vetorDireito)
        {
            int quantidadeElementosVetorEsquerdo = vetorEsquerdo.Length;
            int quantidadeElementosVetorDireito = vetorDireito.Length;
            int indiceVetor = 0;
            int indiceVetorEsquerdo = 0;
            int indiceVetorDireito = 0;
            
            while (indiceVetorEsquerdo < quantidadeElementosVetorEsquerdo && indiceVetorDireito < quantidadeElementosVetorDireito)
            {
                if (vetorEsquerdo[indiceVetorEsquerdo] < vetorDireito[indiceVetorDireito])
                {
                    vetor[indiceVetor] = vetorEsquerdo[indiceVetorEsquerdo];
                    indiceVetor = indiceVetor + 1;
                    indiceVetorEsquerdo = indiceVetorEsquerdo + 1;
                }
                else
                {
                    vetor[indiceVetor] = vetorDireito[indiceVetorDireito];
                    indiceVetor = indiceVetor + 1;
                    indiceVetorDireito = indiceVetorDireito + 1;
                }
            }

            while (indiceVetorEsquerdo < quantidadeElementosVetorEsquerdo)
            {
                vetor[indiceVetor] = vetorEsquerdo[indiceVetorEsquerdo];
                indiceVetor = indiceVetor + 1;
                indiceVetorEsquerdo = indiceVetorEsquerdo + 1;
            }

            while (indiceVetorDireito < quantidadeElementosVetorDireito)
            {
                vetor[indiceVetor] = vetorDireito[indiceVetorDireito];
                indiceVetor = indiceVetor + 1;
                indiceVetorDireito = indiceVetorDireito + 1;
            }
        }
    }
    
    ```