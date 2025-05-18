namespace StructBeaver.Arvores.Avl
{
    public class ArvoreAvl(NoAvl raizAvl)
    {
        public NoAvl RaizAvl = raizAvl;

        private int PegarAlturaNo(NoAvl? noAvl)
            => noAvl?.Altura ?? 0;

        private int FatorBalanceamento(NoAvl? no)
        {
            if (no is null)
                return 0;

            return PegarAlturaNo(no.NoEsquerdo) - PegarAlturaNo(no.NoDireito);
        }

        private void AtualizarAltura(NoAvl no)
        {
            int alturaNoEsquerdo = PegarAlturaNo(no.NoEsquerdo);
            int alturaNoDireito = PegarAlturaNo(no.NoDireito);
            no.Altura = Math.Max(alturaNoEsquerdo, alturaNoDireito) + 1;
        }

        private NoAvl RotacaoSimplesDireita(NoAvl noAtual)
        {
            NoAvl? filhoEsquerdo = noAtual.NoEsquerdo;
            NoAvl? subarvoreDireitaDoFilho = filhoEsquerdo?.NoDireito;

            // Rotaciona
            filhoEsquerdo!.NoDireito = noAtual;
            noAtual.NoEsquerdo = subarvoreDireitaDoFilho;

            // Atualiza alturas
            AtualizarAltura(noAtual);
            AtualizarAltura(filhoEsquerdo);

            return filhoEsquerdo;
        }

        private NoAvl RotacaoSimplesEsquerda(NoAvl noAtual)
        {
            NoAvl? filhoDireito = noAtual!.NoDireito;
            NoAvl? subarvoreEsquerdaDoFilho = filhoDireito!.NoEsquerdo;

            // Rotaciona
            filhoDireito.NoEsquerdo = noAtual;
            noAtual.NoDireito = subarvoreEsquerdaDoFilho;

            // Atualiza alturas
            AtualizarAltura(noAtual);
            AtualizarAltura(filhoDireito);

            return filhoDireito;
        }

        private NoAvl RotacaoDuplaEsquerdaDireita(NoAvl noAtual)
        {
            noAtual.NoEsquerdo = RotacaoSimplesEsquerda(noAtual.NoEsquerdo!);
            return RotacaoSimplesDireita(noAtual);
        }

        private NoAvl RotacaoDuplaDireitaEsquerda(NoAvl noAtual)
        {
            noAtual.NoDireito = RotacaoSimplesDireita(noAtual.NoDireito!);
            return RotacaoSimplesEsquerda(noAtual);
        }

        public NoAvl? Inserir(NoAvl? raiz, int valor)
        {
            if (raiz is null)
                return new NoAvl(valor);

            if (valor < raiz.Valor)
                raiz.NoEsquerdo = Inserir(raiz?.NoEsquerdo, valor);

            else if (valor > raiz.Valor)
                raiz.NoDireito = Inserir(raiz?.NoDireito, valor);

            else
                return raiz;

            AtualizarAltura(raiz!);

            int balanceamento = FatorBalanceamento(raiz);

            if (balanceamento > 1 && valor < raiz!.NoEsquerdo!.Valor)
                return RotacaoSimplesDireita(raiz);

            if (balanceamento < -1 && valor > raiz!.NoDireito!.Valor)
                return RotacaoSimplesEsquerda(raiz);

            if (balanceamento > 1 && valor > raiz!.NoEsquerdo!.Valor)
                return RotacaoDuplaEsquerdaDireita(raiz);

            if (balanceamento < -1 && valor < raiz!.NoDireito!.Valor)
                return RotacaoDuplaDireitaEsquerda(raiz);

            return raiz;
        }

        public NoAvl? Remover(NoAvl raiz, int valor)
        {
            if (raiz is null)
                return null;

            // Passo 1: busca
            if (valor < raiz.Valor)
                raiz.NoEsquerdo = Remover(raiz.NoEsquerdo!, valor);
            else if (valor > raiz.Valor)
                raiz.NoDireito = Remover(raiz.NoDireito!, valor);
            else
            {
                // Passo 2: nó com um ou nenhum filho
                if (raiz.NoEsquerdo is null || raiz.NoDireito is null)
                {
                    NoAvl? temp = null;

                    if (raiz?.NoEsquerdo is not null)
                        temp = raiz.NoEsquerdo;

                    else
                        temp = raiz!.NoDireito;

                    // Sem filhos
                    if (temp is null) 
                        return null;

                    // Um filho
                    else
                        return temp;
                }

                // Passo 3: nó com dois filhos
                NoAvl sucessor = PegarMenorNo(raiz.NoDireito);
                raiz.Valor = sucessor.Valor;
                raiz.NoDireito = Remover(raiz.NoDireito, sucessor.Valor);
            }

            // Passo 4: atualizar altura
            AtualizarAltura(raiz);

            // Passo 5: balancear
            int fator = FatorBalanceamento(raiz);

            // Casos de rotação
            if (fator > 1)
            {
                if (FatorBalanceamento(raiz.NoEsquerdo) >= 0)
                    return RotacaoSimplesDireita(raiz);
                else
                    return RotacaoDuplaEsquerdaDireita(raiz);
            }

            if (fator < -1)
            {
                if (FatorBalanceamento(raiz.NoDireito) <= 0)
                    return RotacaoSimplesEsquerda(raiz);
                else
                    return RotacaoDuplaDireitaEsquerda(raiz);
            }

            return raiz;
        }

        private NoAvl PegarMenorNo(NoAvl no)
        {
            while (no.NoEsquerdo is not null)
                no = no.NoEsquerdo;

            return no;
        }
    }
}