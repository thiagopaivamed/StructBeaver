---

comments: true

---

# **Introdução à Heaps**

![Heaps](heaps.assets/heaps-samurai.png)

Samanosuke é um lendário samurai — experiente, imbatível e respeitado por todos. Ele lidera um poderoso clã, onde a força e a experiência definem a hierarquia.

No clã de Samanosuke, a organização segue uma regra de ferro: o mais forte sempre ocupa o topo.

A hierarquia é clara:

- Samanosuke está no topo.

- Cada samurai sob seu comando pode supervisionar até dois discípulos.

- Nenhum discípulo pode ser mais forte ou mais experiente que o samurai que o comanda.

Essa estrutura forma uma verdadeira pirâmide de poder — ou, na linguagem da computação, uma `Max-Heap`.

Quando um novo samurai é recrutado, ele entra na posição mais baixa e mais à esquerda na hierarquia — o primeiro espaço livre.

Mas esse clã é movido pela meritocracia, com o novo samurai passando por um teste de força e experiência.Se ele se mostrar mais forte que seu superior direto, ele troca de lugar com ele. Esse processo se repete até que o novo guerreiro esteja na posição correta, onde nenhum subordinado é mais forte que ele.

Essa ascensão é chamada de `heapify-up`.

Às vezes, um samurai se retira do clã — seja por honra, idade ou morte em batalha. Quando isso acontece, o último guerreiro da hierarquia é promovido provisoriamente para a posição deixada. Mas ele precisa provar que merece aquele posto. Se ele for mais fraco que algum de seus subordinados, ele troca de lugar com o mais forte deles, até que a hierarquia seja respeitada novamente.

Essa reordenação é chamada de `heapify-down`.

A hierarquia está sempre completa: cada nível é preenchido da esquerda para a direita, sem lacunas.

A posição de cada samurai não depende da ordem de chegada, mas sim de sua prioridade (força e experiência).

No entanto, existe também o clã rival, que adota a lógica inversa: o mais humilde, jovem ou fraco fica no topo.

Esse é o `Min-Heap` — onde os mais "leves" lideram, e a estrutura é organizada do menor para o maior.

Vamos adentrar no mundo das `heaps` e descobrir como podemos utilizá-las.

[10.1 Heaps e suas operações](../heaps/heaps-operacoes.md)

[10.2 Implementação padrão de heaps em C#](../heaps/heaps-c-sharp.md)

[10.3 Exercícios de heaps](../heaps/exercicios-heaps.md)