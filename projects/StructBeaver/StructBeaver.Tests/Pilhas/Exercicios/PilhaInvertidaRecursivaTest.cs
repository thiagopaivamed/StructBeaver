using StructBeaver.Pilhas;
using StructBeaver.Pilhas.Exercicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructBeaver.Tests.Pilhas.Exercicios
{
    public class PilhaInvertidaRecursivaTest
    {
        private PilhaInvertidaRecursiva _pilhaInvertidaRecursiva;

        public PilhaInvertidaRecursivaTest()
            => _pilhaInvertidaRecursiva = new PilhaInvertidaRecursiva();

        [Fact]
        public void InverterPilha_Deve_Retornar_Pilha_Invertida()
        {
            Pilha pilha = new Pilha();
            pilha.Push(1);
            pilha.Push(2);
            pilha.Push(3);
            pilha.Push(4);
            pilha.Push(5);

            pilha = _pilhaInvertidaRecursiva.InverterPilha(pilha);

            Assert.Equal(5, pilha.Pop());
            Assert.Equal(4, pilha.Pop());
            Assert.Equal(3, pilha.Pop());
            Assert.Equal(2, pilha.Pop());
            Assert.Equal(1, pilha.Pop());
        }
    }
}
