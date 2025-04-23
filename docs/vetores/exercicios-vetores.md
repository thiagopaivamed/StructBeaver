---

comments: true

---

# **Exercícios**

(1) Crie um programa que receba palavras e verifique se elas são palíndromos.

??? abstract "Verificando palíndromos"

    ```csharp
    
    public class Palindromos
    {
        public bool IsPalindromo(string palavra)
        {
            int inicio = 0;
            int fim = palavra.Length - 1;

            while (inicio < fim)
            {
                if (palavra[inicio] != palavra[fim])
                    return false;

                inicio = inicio + 1;
                fim = fim - 1;
            }

            return true;
        }
    }

    ```

    ```csharp
    
    string palavra = "arara";

    Padrimos palindromos = new Palindromos();
    bool ehPalindromo = palindromos.IsPalindromo(palavra);

    Console.WriteLine($"A palavra {palavra} {(ehPalindromo ? "é" : "não é")} um palíndromo.")
    
    ```

(2) Crie um programa que receba uma frase e uma palavra. Verifique se essa palavra está na frase recebida.

??? abstract "Procurando palavras"

    ```csharp
    
    public class ProcuraPalavras
    {
        public bool PalavraEstaNoTexto(string texto, string palavra)
        {
            int indiceTexto = 0;
            int indicePalavra = 0;
            int quantidadeCaracteres = palavra.Length;

            while(indiceTexto <= texto.Length - 1 && indicePalavra <= quantidadeCaracteres - 1)
            {
                if (palavra[indicePalavra] == texto[indiceTexto])
                {
                    if (indicePalavra == quantidadeCaracteres - 1)
                        return true;

                    else if (indicePalavra < quantidadeCaracteres - 1)
                        indicePalavra = indicePalavra + 1;

                    else
                    {
                        if (indicePalavra > 0)
                            indicePalavra = 0;
                    }
                }

                indiceTexto = indiceTexto + 1;
            }

            return false;
        }
    }

    ```

    ```csharp
    
    string texto = "O rato roeu a roupa do rei de Roma.";
    string palavra = "roupa";

    ProcuraPalavras procuraPalavras = new ProcuraPalavras();
    bool palavraEstaNoTexto = procuraPalavras.PalavraEstaNoTexto(texto, palavra);
    Console.WriteLine($"A palavra {palavra} {(palavraEstaNoTexto ? "está" : "não está")} no texto.")
    
    ```


(3) Crie um programa que leia 10 números inteiros e armazene-os em um vetor. Após isso, inverta a ordem dos elementos do vetor e exiba o vetor invertido.

??? abstract "Invertendo vetores"

    ```csharp

    public class InverteVetor
    {
        public int[] Inverter(int[] vetor)
        {
            int[] vetorInvertido = new int[vetor.Length];
            int indiceVetorInvertido = 0;

            for (int indice = vetor.Length - 1; indice >= 0; indice--)
            {
                vetorInvertido[indiceVetorInvertido] = vetor[indice];
                indiceVetorInvertido = indiceVetorInvertido + 1;
            }

            return vetorInvertido;
        }
    }

    ```

    ```csharp

    int[] vetor = [30, 1, 5, 77, 19, 32, 97, 36, 42, 66];

    InverteVetor inveterVetor = new InverteVetor();
    int[] vetorInvertido = inverteVetor.Inverter(vetor);

    Console.WriteLine($"Vetor original: {string.Join(", ", vetor)}");

    Console.WriteLine($"Vetor invertido: {string.Join(", ", vetorInvertido)}");
    ```

(4) Crie um programa que leia 10 números inteiros e os armazene em um vetor. Em seguida, encontre e exiba o maior e o menor número do vetor.

??? abstract "Maior e menor valores"

    ```csharp

    public class MaiorMenorNumero
    {
        public string PegarMaiorMenor(int[] vetor)
        {
            int maior = vetor[0];
            int menor = vetor[0];

            for (int indice = 0; indice < vetor.Length; indice++)
            {
                if (vetor[indice] > maior)
                    maior = vetor[indice];
                else if (vetor[indice] < menor)
                    menor = vetor[indice];
            }

            return $"{maior} {menor}";
        }

    ```

    ```csharp

    int[] vetor = [30, 1, 5, 77, 19, 32, 97, 36, 42, 66];
    int maiorNumero;
    int menorNumero;

    MaiorMenorNumero maiorMenorNumero = new MaiorMenorNumero();
    string[] quantidades = maiorMenorNumero.PegarMaiorMenor(vetor).Split(" ");
    maiorNumero = int.Parse(quantidades[0]);
    menorNumero = int.Parse(quantidades[1]);

    Console.WriteLine($"Vetor original: {string.Join(", ", vetor)}");
    Console.WriteLine($"Maior número: {maiorNumero}");
    Console.WriteLine($"Menor número: {menorNumero}");

    ```

(5) Crie um programa que leia 10 números inteiros e os armazene em um vetor. O programa deve então contar quantos números são pares e quantos são ímpares no vetor e exibir essa informação.

??? abstract "Descobrindo pares e impares"

    ```csharp

    public class ParesImpares
    {
        public string ContarParesImpares(int[] vetor)
        {
            int pares = 0;
            int impares = 0;

            for (int indice = 0; indice < vetor.Length; indice++)
            {
                if (vetor[indice] % 2 == 0)
                    pares = pares + 1;
                else
                    impares = impares + 1;
            }

            return $"{pares} {impares}";
        }
    }

    ```

    ```csharp

    int[] vetor = [30, 1, 5, 77, 19, 32, 97, 36, 42, 66];

    int pares;
    int impares;
    ParesImpares paresImpares = new ParesImpares();
    string[] quantidades = paresImpares.ContarParesImpares(vetor).Split(" ");
    
    pares = int.Parse(quantidades[0]);
    impares = int.Parse(quantidades[1]);

    Console.WriteLine($"Quantidade de pares - {pares}")
    Console.WriteLine($"Quantidade de impares - {impares}")

    ```