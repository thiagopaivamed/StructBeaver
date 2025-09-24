---

comments: true

---

# **Representação de grafos**

As formas mais comuns de representar grafos são por meio de uma matriz de adjacência ou de uma lista de adjacência.

## **Matriz de adjacência**

Dado um grafo com `N` vértices, sua representação por matriz de adjacência utiliza uma matriz `N × N`, em que cada linha e cada coluna correspondem a um vértice. O valor armazenado na posição `(i, j)` indica a existência (ou não) de uma aresta entre os vértices `i` e `j`:

- 0: não existe aresta entre os vértices.
- 1: existe uma aresta entre os vértices (ou outro valor, caso seja um grafo ponderado).
  
![Matriz de adjacência](grafos.assets/grafo-matriz-adjacencia.png)

As matrizes de adjacência possuem algumas características importantes:

- Diagonal principal: em grafos simples (sem laços), um vértice não pode estar conectado a si mesmo, portanto todos os elementos da diagonal principal são 0.

- Simetria: em grafos não direcionados, uma aresta entre os vértices `i` e `j` é equivalente à aresta entre `j` e `i`. Por isso, a matriz de adjacência é simétrica em relação à diagonal principal.

- Valores armazenados:
    - Em grafos não ponderados, os elementos da matriz indicam apenas a existência (1) ou ausência (0) de uma aresta.
    - Em grafos ponderados, os elementos podem armazenar o peso associado à aresta correspondente.