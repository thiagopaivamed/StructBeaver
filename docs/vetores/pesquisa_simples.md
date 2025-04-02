---

comments: true

---


# **Pesquisa simples (sequencial)**


Quando for necessário procurar dados em um vetor, é possível fazer uma pesquisa sequencial. Essa pesquisa consiste em executar um loop nesse vetor, passando por cada elemento dele e verificando se o atual elemento é o elemento procurado. Caso seja, retorna-se o índice daquele elemento.

No exemplo abaixo, passamos por todos os índices do vetor procura o elemento 10. Caso não seja encontrado, será retornado -1.

```csharp

int[] vetor = { 3, 1, 2, 7, 10, 4, 8, 6, 12, 15 };
int elementoProcurado = 10;

int indiceElementoProcurado = PesquisaSimples(vetor, elementoProcurado);

Console.Writeline("Resultado da pesquisa - {0}", indiceElementoProcurado);

```

```csharp

 public int PesquisaSimples(int[] vetor, int elementoProcurado)
 {
     for(int indice = 0; indice < vetor.Length -1; indice = indice + 1)
     {
         if (vetor[indice] == elementoProcurado)                
             return indice;                
     }

     return -1;
 }

```


![Pesquisa simples](vetores.assets/pesquisasimples.png)