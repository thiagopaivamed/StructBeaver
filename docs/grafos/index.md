---

comments: true

---

# **Introdução a grafos**

![Grafos](grafos.assets/grafos.png)

Chegou o tão esperado dia que Thaís aguardava: o show da sua banda favorita. Com o ingresso na mão, ela precisava decidir qual caminho seguir até o Rock Paradise Stadium.

Saindo pela rua A, ela tem duas opções: seguir por B ou por C.

- A → B: 3 km

- A → C: 6 km

À primeira vista, optar pelo trecho mais curto (A → B) parece óbvio. Porém, decidir apenas com base no próximo trecho nem sempre garante o menor percurso total.

Se ela escolher B, seguirá depois para D (B → D = 10 km) e, então, do D até o estádio são mais 9 km.
Se escolher C, seguirá para E (C → E = 5 km) e, de E até o estádio, 4 km.

Calculando as rotas completas:

- A → B → D → Estádio = 3 + 10 + 9 = 22 km

- A → C → E → Estádio = 6 + 5 + 4 = 15 km

Perceba: apesar de A → B ser o trecho inicial mais curto, a rota via C é, no total, mais curta.

O que acabamos de ver é a representação de um grafo: uma estrutura formada por vértices (nós — aqui, as ruas) conectados por arestas (caminhos), cada uma com um peso (a distância). 

Veremos a fundo como essa estrutura funciona e como encontrar sempre o caminho mais curto entre dois pontos (por exemplo, usando algoritmos como Dijkstra).

[11.1 Grafos e suas operações](../grafos/grafos-operacoes.md)
[11.2 Representação de grafos](../grafos/grafos-representacao.md)