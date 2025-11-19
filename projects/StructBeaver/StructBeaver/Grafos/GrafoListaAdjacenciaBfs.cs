namespace StructBeaver.Grafos
{
    public class GrafoListaAdjacenciaBfs
    {
        public List<int> Executar(GrafoListaAdjacencia grafo, int verticeInicial)
        {
            List<int> ordemVisita = [];

            HashSet<int> visitados = [];
            visitados.Add(verticeInicial);

            Queue<int> fila = [];
            fila.Enqueue(verticeInicial);

            while (fila.Count > 0)
            {
                int verticeAtual = fila.Dequeue();
                ordemVisita.Add(verticeAtual);

                foreach (int adjacente in grafo.ObterAdjacencias(verticeAtual))
                {
                    if (!visitados.Contains(adjacente))
                    {
                        visitados.Add(adjacente);
                        fila.Enqueue(adjacente);
                    }
                }
            }

            return ordemVisita;
        }
    }
}
