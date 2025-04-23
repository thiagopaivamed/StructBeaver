---

comments: true

---

# **Exercícios recursividade**

(1) Crie um programa que receba um vetor de números inteiros e um número a ser procurado dentro desse vetor. Implemente uma função de pesquisa recursiva que percorra o vetor e retorne o índice da primeira ocorrência do número procurado. Caso o número não seja encontrado, a função deve retornar -1.

??? abstract "Pesquisa recursiva"

    ```csharp

    public class PesquisaSimplesRecursiva
    {
        public int ExecutarPesquisaSimplesRecursiva(int[] vetor, int elementoProcurado, int indice)
        {
            if (indice >= vetor.Length)
                return -1;

            if (vetor[indice] == elementoProcurado)
                return indice;

            return ExecutarPesquisaSimplesRecursiva(vetor, elementoProcurado, indice + 1);
        }
    }

    ```

    ```csharp

        int[] vetor = [3, 1, 2, 7, 10, 4, 8, 6, 12, 15];
        int elementoProcurado = 2;

        PesquisaSimplesRecursiva pesquisaSimplesRecursiva = new PesquisaSimplesRecursiva();
        int indiceElementoProcurado = pesquisaSimplesRecursiva.ExecutarPesquisaSimplesRecursiva(vetor, elementoProcurado, 0);

        Console.WriteLine($"O elemento {elementoProcurado} foi encontrado na posicao {indiceElementoProcurado} no vetor.");

    ```

(2) Crie um programa que receba um vetor de números inteiros e um número a ser procurado dentro desse vetor. Implemente uma função de pesquisa binária recursiva que percorra o vetor e retorne o índice da primeira ocorrência do número procurado. Caso o número não seja encontrado, a função deve retornar -1.

??? abstract "Pesquisa binária recursiva"

    ```csharp

    public class PesquisaBinariaRecursiva
    {
        public int ExecutarPesquisaBinariaRecursiva(int[] vetor, int elementoProcurado, int inicio, int fim)
        {
            if (inicio > fim)
                return -1;

            int meio = (inicio + fim) / 2;

            if (vetor[meio] == elementoProcurado)
                return meio;

            if (vetor[meio] < elementoProcurado)
                return ExecutarPesquisaBinariaRecursiva(vetor, elementoProcurado, meio + 1, fim);

            return ExecutarPesquisaBinariaRecursiva(vetor, elementoProcurado, inicio, meio - 1);
        }
    }

    ```

    ```csharp

            int[] vetor = [3, 1, 2, 7, 10, 4, 8, 6, 12, 15];
            int elementoProcurado = 2;

            PesquisaBinariaRecursiva pesquisaBinariaRecursiva = new PesquisaBinariaRecursiva();
            int indiceElementoProcurado = pesquisaBinariaRecursiva.ExecutarPesquisaBinariaRecursiva(vetor, elementoProcurado);

            Console.WriteLine($"O elemento {elementoProcurado} foi encontrado na posicao {indiceElementoProcurado} no vetor.");

    ```

3. Crie uma função recursiva para verificar se um número inteiro é primo. Um número é primo se ele for maior que 1 e não for divisível por nenhum número que não seja 1 ou ele mesmo.

??? abstract "Número primo"

    ```csharp

    public class NumeroPrimo
    {
        public bool VerificarPrimo(int numero, int divisor)
        {
            if (divisor >= numero)
                return true;

            if (numero % divisor == 0)
                return false;

            return VerificarPrimo(numero, divisor + 1);
        }
    }

    ```

    ```csharp

    int numero = 7;

    NumeroPrimo numeroPrimo = new NumeroPrimo();
    bool primo = numeroPrimero.VerificarPrimo(numero, 2);

    Console.WriteLine($"O numero {numero} {(primo ? "é" : "não é")} primo.");

    ```

(4) Crie uma função recursiva que verifique se uma palavra é um palíndromo, ou seja, se ela pode ser lida da mesma forma de trás para frente. A função deve comparar os primeiros e últimos caracteres recursivamente até que todos os caracteres correspondam.

??? abstract "Palidromo recursivo"

    ```csharp

    public class PalindromoRecursivo
    {
        public bool IsPalindromo(string palavra, int inicio, int fim)
        {
            if (inicio >= fim)
                return true;

            if (palavra[inicio] != palavra[fim])
                return false;

            return IsPalindromo(palavra, inicio + 1, fim - 1);
        }
    }

    ```

    ```csharp

    string palavra = "arara";
    PalindromoRecursivo palindromoRecursivo = new PalindromoRecursivo();
    bool ehPalindromo = _palindromoRecursivo.IsPalindromo(palavra, 0, palavra.Length - 1);

    Console.WriteLine($"A palavra {palavra} {(ehPalindromo ? "é" : "não é")} um palíndromo.")

    ```

(5) Crie uma função recursiva para contar quantos dígitos um número inteiro possui. O número deve ser passado como argumento e a função deve retornar o número de dígitos desse número. Utilize a recursão para dividir o número sucessivamente até que ele se torne zero.

??? abstract "Quantidade de dígitos"

    ```csharp

    public class DigitosRecursivo
    {
        public int PegarQuantidadeDigitos(int numero)
        {
            if (numero < 10)
                return 1;

            return 1 + PegarQuantidadeDigitos(numero / 10);
        }
    }

    ```

    ```csharp

    int numero = 789;

    DigitosRecursivo digitosRecursivo = new DigitosRecursivo();
    int quantidadeDigitos = digitosRecursivo.PegarQuantidadeDigitos(numero);

    Console.WriteLine($"O numero {numero} possui {quantidadeDigitos} digitos.");

    ```