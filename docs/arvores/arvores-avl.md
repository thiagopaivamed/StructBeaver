---

comments: true

---

# **Árvores de Pesquisa Binária Balanceada (AVL)**

Uma árvore AVL é uma árvore binária de busca autobalanceada. À medida que inserimos e removemos nós, o objetivo é mantê-la balanceada utilizando rotações à esquerda e/ou à direita.

Para determinar se uma rotação é necessária, usamos o fator de balanceamento em cada nó. Esse fator pode assumir os seguintes valores:

- -1: indica que a subárvore direita está levemente mais alta

- 0: indica que o nó está balanceado

- 1: indica que a subárvore esquerda está levemente mais alta

O fator de balanceamento (FB) é calculado com a fórmula:
`FB = altura(subárvore esquerda) - altura(subárvore direita)`

Se após uma operação (inserção ou remoção) o fator de balanceamento de algum nó ultrapassar o intervalo de `-1` a `1`, a árvore executará uma ou mais rotações para restaurar o equilíbrio.

Cada nó da árvore possui um atributo de altura, que serve de apoio no cálculo do fator de balanceamento e facilita o controle do balanceamento da árvore.

```csharp

public class NoAvl
{
    public int Valor;
    public NoAvl? Esquerda;
    public NoAvl? Direita;
    public int Altura;

    public NoAvl(int valor)
    {
        Valor = valor;
        Altura = 1;
    }
}

```

## **Tipos de Rotações**

Existem quatro tipos de rotações fundamentais em árvores AVL, utilizadas para corrigir desequilíbrios:

1. **Rotação simples à direita (RR):** aplicada quando o desbalanceamento ocorre no filho esquerdo do filho esquerdo (caso esquerda-esquerda).

2. **Rotação simples à esquerda (LL):** usada quando o desbalanceamento está no filho direito do filho direito (caso direita-direita).

3. **Rotação dupla à direita (LR):** ocorre quando o desbalanceamento acontece no filho direito do filho esquerdo (caso esquerda-direita).

4. **Rotação dupla à esquerda (RL):** necessária quando o desbalanceamento está no filho esquerdo do filho direito (caso direita-esquerda).

