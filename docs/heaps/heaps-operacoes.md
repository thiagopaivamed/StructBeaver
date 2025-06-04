---

comments: true

---

# **Heaps e suas operações**

`Heaps` são estrutura de dados baseadas em árvore binárias completas, comumente usada para a implementação de filas de prioridade.

Pode ser de dois tipos:
1. Max-Heap - o maior valor sempre está no topo (raiz). Cada nó pai é maior ou igual aos seus filhos.
2. Min-Heap - o menor valor está sempre na raiz. Cada nó pai é menor ou igual aos seus filhos.

Ela sempre será uma árvore binária completa, com todos os níveis preenchidos da esquerda para a direita, sem buracos. Normalmente, é representada por um array ou lista. Para um nó na posição `i`, o filho esquerdo está na posição `2i + 1`. Já o direito está na posição `2i + 2`. O pai está na posição `(i -1) / 2`.

![](heaps.assets/heaps-min-max.png)