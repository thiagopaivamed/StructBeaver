---

comments: true

---

# **Como calcular o tempo de execução**

A notação Big O é usada para descrever a eficiência de um algoritmo, especialmente em relação ao tempo de execução conforme o tamanho da entrada cresce.

Imagine que você tem um vetor com n elementos. Se você precisar percorrer todo o vetor uma vez, isso exigirá n operações — logo, dizemos que o tempo de execução é `O(n)`, ou seja, linear.

Agora, e se você tiver que percorrer um vetor dentro de outro vetor? Por exemplo, em um algoritmo com dois laços aninhados. Nesse caso, para cada um dos n elementos do primeiro vetor, você percorre n elementos do segundo. Isso resulta em n * n operações — ou seja, `O(n²)`, uma complexidade quadrática.

Quando o objetivo é procurar um elemento em um vetor, uma pesquisa linear (verificando elemento por elemento) pode ser rápida se o item estiver logo no início — o que levaria `O(1)`, tempo constante. No entanto, no pior caso, pode ser necessário verificar todos os elementos, resultando novamente em `O(n)`.

Mas se o vetor estiver ordenado, podemos aplicar uma pesquisa binária, que a cada passo elimina metade das possibilidades. Isso torna o processo muito mais eficiente, com complexidade `O(log n)` — ou seja, mesmo que o vetor seja grande, o número de operações cresce lentamente.
