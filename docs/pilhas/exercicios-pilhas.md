--- 

comments: true

---

# **Exercícios de pilhas**

(1) Crie um programa que copie os dados de um pilha para outra.

??? abstract "Copiando uma pilha para a outra"

    ```csharp

    public class CopiaPilha
    {
        public Pilha PegarPilhaCopiada(Pilha pilha)
        {
            Pilha pilhaCopiada = new Pilha();
            int quantidadeElementos = pilha.Tamanho();

            for(int i = 0; i < quantidadeElementos; i++)
                pilhaCopiada.Push(pilha.Pop());

            return pilhaCopiada;
        }
    }

    ```    

(2) Crie um programa para pegar o menor valor de uma pilha.

??? abstract "Pegando o menor valor da pilha"

    ```csharp

    public class MenorValorPilha
    {
        public int PegarMenorValor(Pilha pilha)
        {
            int quantidadeElementos = pilha.Tamanho();
            int menorElemento = pilha.Pop();

            for(int i = 0; i < quantidadeElementos - 1; i++)
            {
                int aux = pilha.Pop();
                if (aux < menorElemento) 
                    menorElemento = aux;
            }

            return menorElemento;
        }
    }

    ```   

(3) Crie um programa que converta um número inteiro em sua representação binária usando uma pilha. O programa deve receber um número decimal do usuário e usar a pilha para armazenar os restos da divisão sucessiva por 2, até que o número seja 0. Depois, deve exibir a sequência de restos como o número binário correspondente.

??? abstract "Conversão binária"

    ```csharp

    public class ConversorBinario
    {
        public string ConverterParaBinario(int numero)
        {
            Pilha pilha = new Pilha();

            while(numero > 0)
            {
                int resto = numero % 2;
                pilha.Push(resto);
                numero = numero / 2;
            }

            string numeroBinario = string.Empty;

            while(!pilha.IsEmpty())
            {
                int bit = pilha.Pop();
                numeroBinario = numeroBinario + bit.ToString();
            }

            return numeroBinario;
        }
    }

    ```    

(4) Crie um programa que inverta uma pilha usando recursão.

??? abstract "Usando recursão para inverter uma pilha"

    ```csharp

    public class PilhaInvertidaRecursiva
    {
        public Pilha InverterPilha(Pilha pilha)
        {
            if(pilha.IsEmpty())
                return pilha;

            int elemento = pilha.Pop();

            InverterPilha(pilha);

            pilha.Push(elemento);

            return pilha;
        }
    }

    ```    

(5) Crie um programa que ordene os elementos de uma pilha usando o algorítmo insertion sort recursivo. O algoritmo deve remover os elementos da pilha, armazená-los e, em seguida, recolocá-los na pilha de forma ordenada. Utilize um método recursivo para inserir elementos na pilha de maneira ordenada.

??? abstract "Ordenando pilhas recursivamente"

    ```csharp

    public class OrdenacaoPilha
    {
        public Pilha OrdenarPilha(Pilha pilha)
        {
            int quantidadeElementos = pilha.Tamanho();

            int[] elementos = new int[quantidadeElementos];

            for(int i = 0; i < quantidadeElementos; i++)
                elementos[i] = pilha.Pop();

            int[] elementosOrdenados = RecursiveInsertionSort(elementos, quantidadeElementos);            

            InserirRecursivo(pilha, elementosOrdenados, 0);

            return pilha;
        }

        private int[] RecursiveInsertionSort(int[] vetor, int quantidadeElementos)
        {
            if (quantidadeElementos <= 1)
                return vetor;

            RecursiveInsertionSort(vetor, quantidadeElementos - 1);

            for (int indiceAtual = 1; indiceAtual < quantidadeElementos; indiceAtual++)
            {
                int valorTemporario = vetor[indiceAtual];
                int indiceAuxiliar = indiceAtual - 1;

                while (indiceAuxiliar >= 0 && vetor[indiceAuxiliar] < valorTemporario)
                {
                    vetor[indiceAuxiliar + 1] = vetor[indiceAuxiliar];
                    indiceAuxiliar = indiceAuxiliar - 1;
                }

                vetor[indiceAuxiliar + 1] = valorTemporario;
            }

            return vetor;
        }

        private void InserirRecursivo(Pilha pilha, int[] elementos, int indice)
        {
            if (indice >= elementos.Length)
                return;

            pilha.Push(elementos[indice]);
            InserirRecursivo(pilha, elementos, indice + 1);
        }
    }

    ```