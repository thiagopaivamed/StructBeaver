---

comments: true

---

# **Operações**

Para a realização de operações, vamos começar criando a nossa árvore binária.

```csharp

public class ArvoreBinaria (NoArvore? raiz)
{
    public NoArvore? Raiz = raiz;
}

```

## **Inserção de nós**

Na inserção de nós, precisamos verificar se já temos algum nó na árvore. Se não tiver, esse nó será a raiz. Se já existem nós, precisamos verificar os valores para inserirmos nós menores à esquerda e maiores à direita. No caso de inserção de árvores binárias, não é necessario se preocupar nem com ordenamento nem balanceamento da árvore.

