---

comments: true

---

# **Exercícios de árvores**

(1) Dada uma árvore binária, retorne o número de folhas que ela possui (nós sem filhos).

??? abstract "Quantidade de folhas"

    ```csharp

    public class QuantidadeFolhasArvoreBinaria
    {
        public int ContarFolhas(ArvoreBinaria arvoreBinaria)
        {
            if (arvoreBinaria?.Raiz is null)
                return 0;

            NoArvore raiz = arvoreBinaria.Raiz;

            return Contar(raiz);
        }

        private int Contar(NoArvore noAtual)
        {
            if (noAtual.NoEsquerdo is null && noAtual.NoDireito is null)
                return 1;

            int quantidadeFolhas = 0;

            if (noAtual.NoEsquerdo is not null)
                quantidadeFolhas = quantidadeFolhas + Contar(noAtual.NoEsquerdo);
            if (noAtual.NoDireito is not null)
                quantidadeFolhas = quantidadeFolhas + Contar(noAtual.NoDireito);

            return quantidadeFolhas;
        }
    }

    ```

(2) Dada uma árvore binária, retorne o maior valor dela.

??? abstract "Maior valor"

    ```csharp
    
    public class MaiorValorArvoreBinaria
    {
        public int PegarMaiorValor(ArvoreBinaria arvoreBinaria)
        {
            if (arvoreBinaria?.Raiz is null)
                return 0;

            NoArvore raiz = arvoreBinaria.Raiz;

            if (raiz.NoEsquerdo is null && raiz.NoDireito is null)
                return raiz.Valor;

            return EncontrarMaiorValor(raiz);
        }

        private int EncontrarMaiorValor(NoArvore noArvore)
        {
            if (noArvore is null)
                return int.MinValue;

            int valorAtual = noArvore.Valor;
            int maiorEsquerda = EncontrarMaiorValor(noArvore.NoEsquerdo!);
            int maiorDireita = EncontrarMaiorValor(noArvore.NoDireito!);

            return Math.Max(valorAtual, Math.Max(maiorEsquerda, maiorDireita));
        }
    }
    
    ```

(3) Dada uma árvore binária, crie uma função para fazer o espelhamento (inversão) da mesma.

??? abstract "Espelhamento de árvore"

    ```csharp

    public class EspelhamentoArvoreBinaria
    {
        public ArvoreBinaria? Espelhar(ArvoreBinaria arvoreBinaria)
        {
            if (arvoreBinaria?.Raiz is null)
                return null;

            NoArvore? raiz = EspelharRecursivo(arvoreBinaria.Raiz);

            return new ArvoreBinaria(raiz!);
        }

        private NoArvore? EspelharRecursivo(NoArvore noAtual)
        {
            if (noAtual is null)
                return null;

            NoArvore novoNo = new NoArvore(noAtual.Valor);
            novoNo.NoEsquerdo = EspelharRecursivo(noAtual.NoDireito!);
            novoNo.NoDireito = EspelharRecursivo(noAtual.NoEsquerdo!);

            return novoNo;
        }
    }

    ```

(4) Dada uma árvore binária, crie uma função para a remoção de suas folhas.

??? abstract "Remoção de folhas"

    ```csharp

    public class RemocaoFolhasArvoreBinaria
    {
        public ArvoreBinaria? RemoverFolhas(ArvoreBinaria arvoreBinaria)
        {
            if (arvoreBinaria?.Raiz is null)
                return null;

            arvoreBinaria.Raiz = Remover(arvoreBinaria.Raiz);
            return arvoreBinaria;
        }

        private NoArvore? Remover(NoArvore? noAtual)
        {
            if (noAtual is null)
                return null;

            if (noAtual.NoEsquerdo is null && noAtual.NoDireito is null)
                return null;

            noAtual.NoEsquerdo = Remover(noAtual.NoEsquerdo);
            noAtual.NoDireito = Remover(noAtual.NoDireito);

            return noAtual;
        }
    }

    ```

(5) Dada uma árvore binária, crie uma função para remover todos os nós que tenham exatamente um filho.

??? abstract "Remoção de nós com apenas um filho"

    ```csharp

    public class RemocaoNoComFilhoUnicoArvoreBinaria
    {
        public ArvoreBinaria? RemoverFilhoUnico(ArvoreBinaria arvoreBinaria)
        {
            if (arvoreBinaria?.Raiz is null)
                return null;

            arvoreBinaria.Raiz = Remover(arvoreBinaria.Raiz);

            return arvoreBinaria;
        }

        private NoArvore? Remover(NoArvore? noAtual)
        {
            if (noAtual is null)
                return null;

            if ((noAtual.NoEsquerdo is null && noAtual.NoDireito is not null) || (noAtual.NoEsquerdo is not null && noAtual.NoDireito is null))
                return null;

            noAtual.NoEsquerdo = Remover(noAtual.NoEsquerdo);
            noAtual.NoDireito = Remover(noAtual.NoDireito);

            return noAtual;
        }
    }

    ```

(6) Dada uma árvore de pesquisa binária (BST), crie uma função que calcule a profundidade de um nó.

??? abstract "Profundidade de nós"

    ```csharp

    public class ProfundidadeNoBst
    {
        public int ProfundidadeEmNo(ArvorePesquisaBinaria arvorePesquisaBinaria, NoArvore noProcurado)
        {
            if (arvorePesquisaBinaria?.Raiz is null || noProcurado is null)
                return -1;

            return ProfundidadePreOrdem(arvorePesquisaBinaria.Raiz, noProcurado, 0);
        }

        private int ProfundidadePreOrdem(NoArvore? noAtual, NoArvore noProcurado, int profundidade)
        {
            if (noAtual is null)
                return -1;

            if (noAtual == noProcurado)
                return profundidade;

            int profundidadeEsquerda = ProfundidadePreOrdem(noAtual.NoEsquerdo, noProcurado, profundidade + 1);
            if (profundidadeEsquerda != -1)
                return profundidadeEsquerda;

            return ProfundidadePreOrdem(noAtual.NoDireito, noProcurado, profundidade + 1);
        }
    }

    ```

(7) Dada uma árvore de pesquisa binária (BST), crie uma função que verifique se a mesma está balanceada.

??? abstract "Balaceamento de árvores"

    ```csharp

    public class ArvoreBalanceadaBst
    {
        private bool _ehBalanceada = true;
        public bool EhBalanceada(ArvorePesquisaBinaria arvorePesquisaBinaria)
        {
            if (arvorePesquisaBinaria?.Raiz is null)
                return _ehBalanceada;

            CalcularAltura(arvorePesquisaBinaria.Raiz);

            return _ehBalanceada;
        }

        private int CalcularAltura(NoArvore? noAtual)
        {
            if (noAtual is null)
                return 0;

            int alturaEsquerda = CalcularAltura(noAtual.NoEsquerdo);
            int alturaDireita = CalcularAltura(noAtual.NoDireito);

            if (Math.Abs(alturaEsquerda - alturaDireita) > 1)
                _ehBalanceada = false;

            return Math.Max(alturaEsquerda, alturaDireita) + 1;
        }
    }

    ```

(8) Dada uma árvore de pesquisa binária (BST), crie uma função para calcular o diâmetro dela (maior caminho entre 2 nós).

??? abstract "Diâmetro de arvores"

    ```csharp

    public class DiametroBst
    {
        private int _diametroMaximo = 0;

        public int CalcularDiametro(ArvorePesquisaBinaria arvorePesquisaBinaria)
        {
            if (arvorePesquisaBinaria?.Raiz is null)
                return 0;

            CalcularAltura(arvorePesquisaBinaria.Raiz);

            return _diametroMaximo;
        }

        private int CalcularAltura(NoArvore? noAtual)
        {
            if (noAtual is null)
                return 0;

            int alturaEsquerda = CalcularAltura(noAtual.NoEsquerdo);
            int alturaDireita = CalcularAltura(noAtual.NoDireito);

            int diametroNoAtual = alturaEsquerda + alturaDireita + 1;
            if (diametroNoAtual > _diametroMaximo)
                _diametroMaximo = diametroNoAtual;

            return Math.Max(alturaEsquerda, alturaDireita) + 1;
        }
    }

    ```

(9) Dada uma árvore de pesquisa binária (BST), crie uma função para substitua o valor de cada nó pela soma dos valores da subárvore.

??? abstract "Soma de nós"

    ```csharp

    public class SomaSubarvoreBst
    {
        public ArvorePesquisaBinaria? SubstituirPorSomaSubarvore(ArvorePesquisaBinaria arvore)
        {
            if (arvore?.Raiz is null)
                return arvore;

            Substituir(arvore.Raiz);
            return arvore;
        }

        private int Substituir(NoArvore noAtual)
        {
            if (noAtual is null)
                return 0;

            int somaEsquerda = Substituir(noAtual.NoEsquerdo!);
            int somaDireita = Substituir(noAtual.NoDireito!);

            int novoValor = somaEsquerda + somaDireita + noAtual.Valor;
            noAtual.Valor = novoValor;

            return novoValor;
        }
    }

    ```

(10) Dada uma árvore de pesquisa binária (BST), crie uma função que conte quantos nós têm dois filhos.

??? abstract "Quantidade de nós com dois filhos"

    ```csharp

    public class QuantidadeNosDoisFilhosBst
    {
        public int ContarNosDoisFilhos(ArvorePesquisaBinaria arvorePesquisaBinaria)
        {
            if (arvorePesquisaBinaria?.Raiz is null)
                return 0;

            return Contar(arvorePesquisaBinaria.Raiz);
        }

        private int Contar(NoArvore? noAtual)
        {
            if (noAtual is null)
                return 0;

            int quantidadeNosDoisFilhos = 0;

            if (noAtual.NoEsquerdo is not null && noAtual.NoDireito is not null)
                quantidadeNosDoisFilhos = 1;

            quantidadeNosDoisFilhos = quantidadeNosDoisFilhos + Contar(noAtual.NoEsquerdo);
            quantidadeNosDoisFilhos = quantidadeNosDoisFilhos + Contar(noAtual.NoDireito);

            return quantidadeNosDoisFilhos;
        }
    }

    ```

(11) Dada uma árvore AVL, crie uma função que conte quantos nós existem nela.

??? abstract "Contagem de nós"

    ```csharp

    public class QuantidadeNosAvl
    {
        public int ContarQuantidadeNos(ArvoreAvl arvore)
        {
            if (arvore?.RaizAvl is null)
                return 0;

            return Contar(arvore.RaizAvl);
        }

        private int Contar(NoAvl? noAtual)
        {
            if (noAtual is null)
                return 0;

            return 1 + Contar(noAtual.NoEsquerdo) + Contar(noAtual.NoDireito);
        }
    }

    ```

(12) Dada uma árvore AVL, crie uma função que verifique se a árvore está balanceada.

??? abstract "Árvore balanceada"

    ```csharp

    public class BalanceamentoAvl
    {
        public bool EhBalanceada(ArvoreAvl arvore)
        {
            if (arvore?.RaizAvl is null)
                return true;

            return VerificarBalanceamento(arvore.RaizAvl);
        }

        private bool VerificarBalanceamento(NoAvl? noAtual)
        {
            if (noAtual is null)
                return true;

            int alturaEsquerda = noAtual.NoEsquerdo?.Altura ?? 0;
            int alturaDireita = noAtual.NoDireito?.Altura ?? 0;

            int fatorBalanceamento = alturaEsquerda - alturaDireita;

            if (Math.Abs(fatorBalanceamento) > 1)
                return false;

            return VerificarBalanceamento(noAtual.NoEsquerdo) && VerificarBalanceamento(noAtual.NoDireito);
        }
    }

    ```

(13) Dada uma árvore AVL, crie uma função para realizar a pesquisa binária de um nó.

??? abstract "Pesquisa binária em árvore"

    ```csharp

    public class PesquisaBinariaAvl
    {
        public NoAvl? Pesquisar(ArvoreAvl arvoreAvl, int valorProcurado)
        {
            if (arvoreAvl?.RaizAvl is null)
                return null;

            NoAvl raiz = arvoreAvl.RaizAvl;

            if (raiz.Valor == valorProcurado)
                return raiz;

            return Pesquisar(raiz, valorProcurado);
        }

        private NoAvl? Pesquisar(NoAvl? noAtual, int valorProcurado)
        {
            if (noAtual is null)
                return null;

            if (noAtual.Valor == valorProcurado)
                return noAtual;

            if (valorProcurado < noAtual.Valor)
                return Pesquisar(noAtual.NoEsquerdo, valorProcurado);

            return Pesquisar(noAtual.NoDireito, valorProcurado);
        }
    }

    ```

(14) Dada uma árvore AVL, crie uma função que conte a quantidade nós desbalanceados.

??? abstract "Contagem de nós desbalanceados"

    ```csharp

    public class QuantidadeNosDesbalanceadosAvl
    {
        public int ContarNosDesbalanceados(ArvoreAvl arvore)
        {
            if (arvore?.RaizAvl is null)
                return 0;

            return ContarNosDesbalanceados(arvore.RaizAvl);
        }

        private int ContarNosDesbalanceados(NoAvl? noAtual)
        {
            if (noAtual is null)
                return 0;

            int alturaEsquerda = noAtual.NoEsquerdo?.Altura ?? 0;
            int alturaDireita = noAtual.NoDireito?.Altura ?? 0;

            int fatorBalanceamento = alturaEsquerda - alturaDireita;

            int quantidadeNosDesbalanceados = 0;

            if (Math.Abs(fatorBalanceamento) > 1)
                quantidadeNosDesbalanceados = 1;

            quantidadeNosDesbalanceados = quantidadeNosDesbalanceados + ContarNosDesbalanceados(noAtual.NoEsquerdo);
            quantidadeNosDesbalanceados = quantidadeNosDesbalanceados + ContarNosDesbalanceados(noAtual.NoDireito);

            return quantidadeNosDesbalanceados;
        }
    }

    ```

(15) Dada uma árvore AVL, crie uma função que retorne o menor valor da árvore.

??? abstract "Menor valor da árvore"

    ```csharp

    public class MenorValorAvl
    {
        public int? PegarMenorValor(ArvoreAvl arvore)
        {
            if (arvore?.RaizAvl is null)
                return null;

            NoAvl noAtual = arvore.RaizAvl;

            while (noAtual.NoEsquerdo is not null)
                noAtual = noAtual.NoEsquerdo;

            return noAtual.Valor;
        }
    }

    ```