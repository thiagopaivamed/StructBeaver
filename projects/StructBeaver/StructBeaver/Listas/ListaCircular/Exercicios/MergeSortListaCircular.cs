namespace StructBeaver.Listas.ListaCircular.Exercicios
{
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
}