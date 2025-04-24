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

    ```csharp
    
    Fila filaOriginal = new Fila();

    filaOriginal.Enqueue(1);
    filaOriginal.Enqueue(2);
    filaOriginal.Enqueue(3);
    filaOriginal.Enqueue(4);
    filaOriginal.Enqueue(5);

    Fila filaCopia = copiaFila.CopiarDados(filaOriginal);

    Console.WriteLine($"Os valores da fila copiada são ");

    Console.WriteLine($"{filaCopia.Peek()} ");
    filaCopia.Dequeue();

    Console.WriteLine($"{filaCopia.Peek()} ");
    filaCopia.Dequeue();

    Console.WriteLine($"{filaCopia.Peek()} ");
    filaCopia.Dequeue();

    Console.WriteLine($"{filaCopia.Peek()} ");
    filaCopia.Dequeue();

    Console.WriteLine($"{filaCopia.Peek()} ");
    filaCopia.Dequeue();

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

    ```csharp
    
    Fila fila1 = new Fila();
    Fila fila2 = new Fila();

    fila1.Enqueue(1);
    fila1.Enqueue(2);
    fila1.Enqueue(3);
    fila1.Enqueue(4);
    fila1.Enqueue(5);

    fila2.Enqueue(1);
    fila2.Enqueue(2);
    fila2.Enqueue(3);
    fila2.Enqueue(4);
    fila2.Enqueue(5);

    bool filasSaoIguais = _verificaFilas.VerificarFilasPorOrdemValores(fila1, fila2);

    Console.WriteLine("As filas {(filasSaoIguais ? "são" : "não são")} iguais.");

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

    ```csharp
    
    Fila fila = new Fila();

    fila.Enqueue(1);
    fila.Enqueue(2);
    fila.Enqueue(3);
    fila.Enqueue(4);
    fila.Enqueue(5);

    double media = _mediaValoresFila.CalcularMedia(fila);

    Console.WriteLine($"A media dos valores da fila é {media}.");
    
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

    ```csharp
    
    Fila fila = new Fila();

    fila.Enqueue(1);
    fila.Enqueue(2);
    fila.Enqueue(3);
    fila.Enqueue(4);
    fila.Enqueue(5);

    fila = _rotacaoFila.Rotacionar(fila, 2);

    Console.WriteLine($"A fila rotacionada é ");

    Console.WriteLine($"{fila.Peek}");
    fila.Dequeue();

    Console.WriteLine($"{fila.Peek}");
    fila.Dequeue();

    Console.WriteLine($"{fila.Peek}");
    fila.Dequeue();

    Console.WriteLine($"{fila.Peek}");
    fila.Dequeue();

    Console.WriteLine($"{fila.Peek}");
    fila.Dequeue();
    
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

    ```csharp
    
    Fila fila = new Fila();

    fila.Enqueue(5);
    fila.Enqueue(3);
    fila.Enqueue(1);
    fila.Enqueue(4);
    fila.Enqueue(2);

    fila = _ordenacaoFila.Ordenar(fila);

    Console.WriteLine($"A fila ordenada é ");

    Console.WriteLine($"{fila.Peek()}");
    fila.Dequeue();

    Console.WriteLine($"{fila.Peek()}");
    fila.Dequeue();

    Console.WriteLine($"{fila.Peek()}");
    fila.Dequeue();

    Console.WriteLine($"{fila.Peek()}");
    fila.Dequeue();

    Console.WriteLine($"{fila.Peek()}");
    fila.Dequeue();
    
    ```