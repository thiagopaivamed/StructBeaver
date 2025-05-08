---

comments: true

---

# **Exercícios**

(1) Dada uma lista encadeada, crie uma função para inverter os seus elementos.

??? abstract "Invertendo elementos"

    ```csharp
    
    public class InversaoElementosListaEncadeada
    {
        public ListaEncadeada Inverter(ListaEncadeada listaParaInversao)
        {
            ListaEncadeada listaInvertida = new ListaEncadeada();

            while (!listaParaInversao.IsEmpty())
            {
                No noRemovido = listaParaInversao.RemoverNoInicio();

                if (noRemovido is not null)
                    listaInvertida.AdicionarNoInicio(noRemovido.Valor);
            }

            return listaInvertida;
        }
    }

    ```

(2) Dada uma lista encadeada, crie uma função recursiva para fazer a pesquisa de um valor.

??? abstract "Pesquisa valores em lista de forma recursiva"

    ```csharp
    
    public class PesquisaRecursivaListaEncadeada
    {
        public bool Pesquisar(ListaEncadeada listaEncadeada, int valorProcurado)
        {
            No noAtual = listaEncadeada.PegarPrimeiroNo();

            return PesquisarRecursivo(noAtual, valorProcurado);
        }

        private bool PesquisarRecursivo(No noAtual, int valorProcurado)
        {
            if (noAtual is null)
                return false;

            if (noAtual.Valor == valorProcurado)
                return true;

            return PesquisarRecursivo(noAtual.Proximo, valorProcurado);
        }
    }

    ```

(3) Dadas duas listas encadeadas, implemente uma função recursiva que as mescle em uma única lista encadeada.

??? abstract "Juntando listas recursivamente"

    ```csharp
    
    public class JuncaoListasEncadeadas
    {
        public ListaEncadeada FazerMerge(ListaEncadeada lista1, ListaEncadeada lista2)
        {
            ListaEncadeada listasCombinadas = new ListaEncadeada();

            No? no1 = lista1.PegarPrimeiroNo();
            No? no2 = lista2.PegarPrimeiroNo();

            return MergeRecursivo(no1, no2, listasCombinadas);           
        }

        private ListaEncadeada MergeRecursivo(No? no1, No? no2, ListaEncadeada listasCombinadas)
        {
            if(no1 is null && no2 is null)            
                return listasCombinadas;

            if (no1 is not null)
                listasCombinadas.AdicionarNoFim(no1.Valor);

            if (no2 is not null)
                listasCombinadas.AdicionarNoFim(no2.Valor);

            return MergeRecursivo(no1?.Proximo, no2?.Proximo, listasCombinadas);            
        }
    }

    ```

(4) Dado uma lista encadeada, utilize a ordenação por inserção (insertion sort) para ordenar seus elementos.

??? abstract "Insertion Sort para listas"

    ```csharp
    
    public class InsertionSortListaEncadeada
    {
        public ListaEncadeada Ordenar(ListaEncadeada listaParaOrdenar)
        {
            ListaEncadeada listaOrdenada = new ListaEncadeada();
            No? noAtual = listaParaOrdenar.PrimeiroNo;

            while (noAtual != null)
            {
                No novoNo = new No(noAtual.Valor);

                if (listaOrdenada.PrimeiroNo is null || novoNo.Valor < listaOrdenada.PrimeiroNo.Valor)
                {
                    novoNo.Proximo = listaOrdenada.PrimeiroNo;
                    listaOrdenada.PrimeiroNo = novoNo;
                }

                else
                {
                    No noBusca = listaOrdenada.PrimeiroNo;

                    while (noBusca.Proximo != null && noBusca.Proximo.Valor < novoNo.Valor)
                        noBusca = noBusca.Proximo;

                    novoNo.Proximo = noBusca.Proximo;
                    noBusca.Proximo = novoNo;
                }

                noAtual = noAtual.Proximo;
            }

            return listaOrdenada;
        }
    }

    ```

(5) Dado uma lista encadeada, crie uma função para realizar uma pesquisa binária recursiva na mesma.

??? abstract "Pesquisa binária recursiva em listas"

    ```csharp
    
    public class PesquisaRecursivaListaEncadeada
    {
        public bool Pesquisar(ListaEncadeada listaEncadeada, int valorProcurado)
        {
            No noAtual = listaEncadeada.PegarPrimeiroNo();

            return PesquisarRecursivo(noAtual, valorProcurado);
        }

        private bool PesquisarRecursivo(No noAtual, int valorProcurado)
        {
            if (noAtual is null)
                return false;

            if (noAtual.Valor == valorProcurado)
                return true;

            return PesquisarRecursivo(noAtual.Proximo, valorProcurado);
        }
    }

    ```

(6) Dada uma lista duplamente encadeada, crie uma função recursiva para a remoção de seus elementos.

??? abstract "Remoção recursiva de lista duplamente encadeada"

    ```csharp
    
    public class RemocaoRecursivaListaDuplamenteEncadeada
    {
        public NoDuplamenteEncadeado Remover(ListaDuplamenteEncadeada lista, int valor)
        {
            NoDuplamenteEncadeado primeiroNo = lista.PegarPrimeiroNo();

            return RemoverRecursivo(lista, primeiroNo, valor);
        }

        private NoDuplamenteEncadeado RemoverRecursivo(ListaDuplamenteEncadeada lista, NoDuplamenteEncadeado noAtual, int valor)
        {
            if (noAtual is null)
                return null;

            if (noAtual.Valor == valor)
            {
                NoDuplamenteEncadeado primeiroNo = lista.PegarPrimeiroNo();
                NoDuplamenteEncadeado ultimoNo = lista.PegarUltimoNo();

                if (noAtual == primeiroNo)
                {
                    if (noAtual.Proximo is null)
                    {
                        lista.PrimeiroNo = null;
                        lista.UltimoNo = null;
                    }

                    else
                    {
                        lista.PrimeiroNo = noAtual.Proximo;
                        noAtual.Proximo.Anterior = null;
                    }
                }
                
                else if (noAtual == ultimoNo)
                {
                    if (noAtual.Anterior is null)
                    {
                        lista.PrimeiroNo = null;
                        lista.UltimoNo = null;
                    }

                    else
                    {
                        lista.UltimoNo = noAtual.Anterior;
                        noAtual.Anterior.Proximo = null;
                    }
                }
                
                else
                {
                    noAtual.Anterior!.Proximo = noAtual.Proximo;
                    noAtual.Proximo!.Anterior = noAtual.Anterior;
                }

                noAtual.Proximo = null;
                noAtual.Anterior = null;

                return noAtual; 
            }

            return RemoverRecursivo(lista, noAtual.Proximo, valor);
        }
    }

    ```

(7) Dada uma lista duplamente encadeada, crie uma função para a remoção de todos os valores pares.

??? abstract "Remoção de números pares em lista duplamente encadeada"

    ```csharp
    
    public class RemocaoParesListaDuplamenteEncadeada
    {
        public ListaDuplamenteEncadeada Remover(ListaDuplamenteEncadeada listaDuplamenteEncadeada)
        {
            NoDuplamenteEncadeado noAtual = listaDuplamenteEncadeada.PegarPrimeiroNo();

            while (noAtual is not null)
            {
                NoDuplamenteEncadeado proximoNo = noAtual.Proximo;

                if (noAtual.Valor % 2 == 0)
                    listaDuplamenteEncadeada.Remover(noAtual.Valor);

                noAtual = proximoNo;
            }

            return listaDuplamenteEncadeada;
        }
    }

    ```

(8) Dada uma lista duplamente encadeada, crie uma função recursiva para inverter seus elementos.

??? abstract "Inversão recursiva de elementos em lista duplamente encadeada"

    ```csharp
    
    public class InversaoRecursivaListaDuplamenteEncadeada
    {
        public ListaDuplamenteEncadeada Inverter(ListaDuplamenteEncadeada listaDuplamenteEncadeada)
        {
            NoDuplamenteEncadeado primeiroNo = listaDuplamenteEncadeada.PegarPrimeiroNo();

            if (primeiroNo is null)
                return listaDuplamenteEncadeada;

            InverterRecursivo(primeiroNo, listaDuplamenteEncadeada);

            NoDuplamenteEncadeado noTemporario = listaDuplamenteEncadeada.PrimeiroNo;
            listaDuplamenteEncadeada.PrimeiroNo = listaDuplamenteEncadeada.UltimoNo;
            listaDuplamenteEncadeada.UltimoNo = noTemporario;

            return listaDuplamenteEncadeada;
        }

        private ListaDuplamenteEncadeada InverterRecursivo(NoDuplamenteEncadeado noAtual, ListaDuplamenteEncadeada listaDuplamenteEncadeada)
        {
            NoDuplamenteEncadeado noTemporario = noAtual.Proximo;
            noAtual.Proximo = noAtual.Anterior;
            noAtual.Anterior = noTemporario;

            if (noAtual.Anterior is null)
                return listaDuplamenteEncadeada;

            return InverterRecursivo(noAtual.Anterior, listaDuplamenteEncadeada);
        }
    }

    ```

(9) Dada uma lista duplamente encadeada, ordene seus elementos de forma decrescente usando o método de ordenação rápida (quick sort).

??? abstract "Ordenação decrescente com Quick Sort de lista duplamente encadeada"

    ```csharp
    
    public class QuickSortDecrescenteListaDuplamenteEncadeada
    {
        public ListaDuplamenteEncadeada QuickSortDecrescente(ListaDuplamenteEncadeada listaParaOrdenacao)
        {
            NoDuplamenteEncadeado primeiroNo = listaParaOrdenacao.PegarPrimeiroNo();

            if (primeiroNo is null)
                return listaParaOrdenacao;

            NoDuplamenteEncadeado ultimoNo = listaParaOrdenacao.PegarUltimoNo();

            OrdenarComQuickSort(primeiroNo, ultimoNo, listaParaOrdenacao);

            return listaParaOrdenacao;
        }

        private void OrdenarComQuickSort(NoDuplamenteEncadeado inicio, NoDuplamenteEncadeado fim, ListaDuplamenteEncadeada listaParaOrdenacao)
        {
            if (inicio is null || fim is null || inicio == fim || inicio.Anterior == fim)
                return;

            NoDuplamenteEncadeado pivo = Particionar(inicio, fim);

            if (pivo.Anterior is not null)
                OrdenarComQuickSort(inicio, pivo.Anterior, listaParaOrdenacao);
            if (pivo.Proximo is not null)
                OrdenarComQuickSort(pivo.Proximo, fim, listaParaOrdenacao);
        }

        private NoDuplamenteEncadeado Particionar(NoDuplamenteEncadeado inicio, NoDuplamenteEncadeado fim)
        {
            int valorPivo = fim.Valor;
            NoDuplamenteEncadeado? noMenor = inicio.Anterior;
            NoDuplamenteEncadeado noAtual = inicio;

            while (noAtual != fim)
            {
                if (noAtual.Valor >= valorPivo)
                {
                    if(noMenor is null)
                        noMenor = inicio;

                    else
                        noMenor = noMenor.Proximo;

                    Trocar(noMenor!, noAtual);
                }
                noAtual = noAtual.Proximo!;
            }

            if (noMenor is null)
                noMenor = inicio;

            else
                noMenor = noMenor.Proximo;

            Trocar(noMenor, fim);

            return noMenor;
        }

        private void Trocar(NoDuplamenteEncadeado noA, NoDuplamenteEncadeado noB)
        {
            int valorTemp = noA.Valor;
            noA.Valor = noB.Valor;
            noB.Valor = valorTemp;
        }
    }

    ```

(10) Dada uma lista duplamente encadeada ordenada, implemente uma função recursiva que realize a busca binária de um valor específico.

??? abstract "Pesquisa binária recursiva em lista duplamente encadeada"

    ```csharp
    
    public class PesquisaBinariaListaDuplamenteEncadeada
    {
        public bool Pesquisar(ListaDuplamenteEncadeada listaParaProcura, int valorProcurado)
        {
            NoDuplamenteEncadeado primeiroNo = listaParaProcura.PegarPrimeiroNo();
            NoDuplamenteEncadeado ultimoNo = listaParaProcura.PegarUltimoNo();

            return PesquisaBinariaRecursiva(primeiroNo, ultimoNo, valorProcurado);
        }

        private bool PesquisaBinariaRecursiva(NoDuplamenteEncadeado noInicial, NoDuplamenteEncadeado noFinal, int valorProcurado)
        {
            if (noInicial is null || noFinal is null)
                return false;

            NoDuplamenteEncadeado atual = noInicial;

            while (atual is not null && atual != noFinal)
                atual = atual.Proximo;

            if (atual != noFinal)
                return false;

            NoDuplamenteEncadeado ponteiroInicio = noInicial;
            NoDuplamenteEncadeado ponteiroFim = noFinal;

            while (ponteiroInicio != ponteiroFim && ponteiroInicio.Proximo != ponteiroFim)
            {
                ponteiroInicio = ponteiroInicio?.Proximo;
                ponteiroFim = ponteiroFim?.Anterior;
            }

            NoDuplamenteEncadeado noMeio = ponteiroInicio;

            if (noMeio is null)
                return false;

            if (noMeio.Valor == valorProcurado)
                return true;

            if (valorProcurado < noMeio.Valor)
                return PesquisaBinariaRecursiva(noMeio.Proximo, noFinal, valorProcurado);

            return PesquisaBinariaRecursiva(noInicial, noMeio.Anterior, valorProcurado);
        }
    }

    ```

(11) Dada uma lista circular, implemente uma função que percorra seus nós e retorne a quantidade total de elementos presentes na lista.

??? abstract "Quantidade de nós em lista circular"

    ```csharp
    
    public class QuantidadeNosListaCircular
    {
        public int ContarQuantidadeNos(ListaCircularDuplamenteEncadeada listaCircularDuplamenteEncadeada)
        {
            NoCircular noAtual = listaCircularDuplamenteEncadeada.PrimeiroNo;

            if(noAtual is null)
                return 0;

            NoCircular primeiroNo = noAtual;
            int quantidadeNos = 0;

            while (noAtual.Proximo != primeiroNo)
            {
                quantidadeNos = quantidadeNos + 1;
                noAtual = noAtual.Proximo;
            }

            return quantidadeNos + 1;
        }
    }

    ```

(12) Dada uma lista circular, crie uma função para procurar recursivamente um elemento.

??? abstract "Pesquisa recursiva em lista circular"

    ```csharp
    
    public class PesquisaRecursivaListaCircular
    {
        public bool Pesquisar(ListaCircularDuplamenteEncadeada listaCircularDuplamenteEncadeada, int valorProcurado)
        {
            NoCircular noAtual = listaCircularDuplamenteEncadeada.PrimeiroNo;

            if (noAtual is null) 
                return false;

            return PesquisarRecursivo(noAtual, noAtual, valorProcurado);
        }

        private bool PesquisarRecursivo(NoCircular noAtual, NoCircular primeiroNo, int valorProcurado)
        {
            if (noAtual.Valor == valorProcurado)
                return true;

            if(noAtual.Proximo == primeiroNo)
                return false;

            return PesquisarRecursivo(noAtual.Proximo, primeiroNo, valorProcurado);
        }
    }

    ```

(13) Dada uma lista circular, implemente uma função que percorra a lista e remova todos os nós cujo valor seja múltiplo de 5.

??? abstract "Removendo múltiplos de 5 em lista circular"

    ```csharp
    
    public class RemoveMultiploDeCincoListaCircular
    {
        public ListaCircularDuplamenteEncadeada RemoverMultiploDeCinco(ListaCircularDuplamenteEncadeada listaCircular)
        {
            NoCircular noAtual = listaCircular.PrimeiroNo;
            NoCircular primeiroNo = noAtual;

            while (noAtual.Proximo is not null && (noAtual.Proximo != primeiroNo || noAtual.Valor % 5 == 0))
            {
                if (noAtual.Valor % 5 == 0)
                {
                    NoCircular proximoNo = noAtual.Proximo;
                    listaCircular.Remover(noAtual.Valor);

                    if (noAtual.Valor == primeiroNo.Valor)
                        primeiroNo = proximoNo;

                    noAtual = proximoNo;
                }

                else
                    noAtual = noAtual.Proximo;

            }

            return listaCircular;
        }
    }

    ```

(14) Dada uma lista circular, crie uma função que rotacione os elementos da lista circular N posições.

??? abstract "Rotação de elementos em lista circular"

    ```csharp
    
    public class RotacaoListaCircular
    {
        public ListaCircularDuplamenteEncadeada Rotacionar(ListaCircularDuplamenteEncadeada listaCircular, int quantidadeRotacoes)
        {
            NoCircular noAtual = listaCircular.PrimeiroNo;

            for (int i = 0; i < quantidadeRotacoes; i++)
                noAtual = noAtual.Proximo;            

            listaCircular.PrimeiroNo = noAtual;

            return listaCircular;
        }
    }

    ```

(15) Dada uma lista circular, use o Merge Sort para ordenar seus elementos.

??? abstract "Merge Sort em lista circular"

    ```csharp
    
    public class MergeSortListaCircular
    {
        public ListaCircularDuplamenteEncadeada Ordenar(ListaCircularDuplamenteEncadeada listaCircularOriginal)
        {
            NoCircular primeiroNo = listaCircularOriginal.PegarPrimeiroNo();

            if (primeiroNo is null || primeiroNo.Proximo == primeiroNo)
                return listaCircularOriginal;

            ListaCircularDuplamenteEncadeada nosEsquerda = new ListaCircularDuplamenteEncadeada();
            ListaCircularDuplamenteEncadeada nosDireita = new ListaCircularDuplamenteEncadeada();

            DividirListaAoMeio(listaCircularOriginal, nosEsquerda, nosDireita);

            ListaCircularDuplamenteEncadeada primeiraMetadeOrdenada = Ordenar(nosEsquerda);
            ListaCircularDuplamenteEncadeada segundaMetadeOrdenada = Ordenar(nosDireita);

            return JuntarListasOrdenadas(primeiraMetadeOrdenada, segundaMetadeOrdenada);
        }

        private void DividirListaAoMeio(ListaCircularDuplamenteEncadeada listaOriginal,
            ListaCircularDuplamenteEncadeada nosEsquerda,
            ListaCircularDuplamenteEncadeada nosDireita)
        {
            NoCircular ponteiroParaInicio = listaOriginal.PrimeiroNo;
            NoCircular ponteiroParaFinal = listaOriginal.PrimeiroNo;

            while (
                ponteiroParaFinal.Proximo != listaOriginal.PrimeiroNo &&
                ponteiroParaFinal.Proximo.Proximo != listaOriginal.PrimeiroNo)
            {
                ponteiroParaInicio = ponteiroParaInicio.Proximo;
                ponteiroParaFinal = ponteiroParaFinal.Proximo.Proximo;
            }

            NoCircular ultimoNoEsquerda = ponteiroParaInicio;
            NoCircular noAtual = listaOriginal.PrimeiroNo;

            while (noAtual != ultimoNoEsquerda.Proximo)
            {
                nosEsquerda.AdicionarNoFim(noAtual.Valor);
                noAtual = noAtual.Proximo;
            }

            while (noAtual != listaOriginal.PrimeiroNo)
            {
                nosDireita.AdicionarNoFim(noAtual.Valor);
                noAtual = noAtual.Proximo;
            }
        }

        private ListaCircularDuplamenteEncadeada JuntarListasOrdenadas(
            ListaCircularDuplamenteEncadeada nosEsquerda,
            ListaCircularDuplamenteEncadeada nosDireita)
        {
            ListaCircularDuplamenteEncadeada listaOrdenada = new ListaCircularDuplamenteEncadeada();

            NoCircular noAtualEsquerda = nosEsquerda.PrimeiroNo;
            NoCircular noAtualDireita = nosDireita.PrimeiroNo;

            int totalNosEsquerda = PegarQuantidadeDeNos(nosEsquerda);
            int totalNosDireita = PegarQuantidadeDeNos(nosDireita);

            int contadorNosEsquerda = 0;
            int contadorNosDireita = 0;

            while (contadorNosEsquerda < totalNosEsquerda || contadorNosDireita < totalNosDireita)
            {
                bool deveAdicionarDaPrimeiraLista = false;

                if (contadorNosEsquerda < totalNosEsquerda && (contadorNosDireita >= totalNosDireita || noAtualEsquerda.Valor <= noAtualDireita.Valor))
                    deveAdicionarDaPrimeiraLista = true;

                if (deveAdicionarDaPrimeiraLista)
                {
                    listaOrdenada.AdicionarNoFim(noAtualEsquerda.Valor);
                    noAtualEsquerda = noAtualEsquerda.Proximo;
                    contadorNosEsquerda = contadorNosEsquerda + 1;
                }
                else
                {
                    listaOrdenada.AdicionarNoFim(noAtualDireita.Valor);
                    noAtualDireita = noAtualDireita.Proximo;
                    contadorNosDireita = contadorNosDireita + 1;
                }
            }

            return listaOrdenada;
        }

        private int PegarQuantidadeDeNos(ListaCircularDuplamenteEncadeada listaCircular)
        {
            if (listaCircular.PrimeiroNo is null)
                return 0;

            int quantidadeNos = 1;
            NoCircular noAtual = listaCircular.PrimeiroNo.Proximo;

            while (noAtual != listaCircular.PrimeiroNo)
            {
                quantidadeNos = quantidadeNos + 1;
                noAtual = noAtual.Proximo;
            }

            return quantidadeNos;
        }
    }

    ```
