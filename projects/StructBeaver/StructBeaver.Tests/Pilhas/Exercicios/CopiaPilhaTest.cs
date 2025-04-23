using StructBeaver.Pilhas;
using StructBeaver.Pilhas.Exercicios;

namespace StructBeaver.Tests.Pilhas.Exercicios
{
    public class CopiaPilhaTest
    {
        private CopiaPilha _copiaPilha;

        public CopiaPilhaTest()
            => _copiaPilha = new CopiaPilha();        

        [Fact]
        public void PegarPilhaCopiada_Deve_Retornar_Pilha_Copiada()
        {            
            Pilha pilhaOriginal = new Pilha();
            pilhaOriginal.Push(1);
            pilhaOriginal.Push(2);
            pilhaOriginal.Push(3);
            pilhaOriginal.Push(4);
            pilhaOriginal.Push(5);
            
            Pilha pilhaCopiada = _copiaPilha.PegarPilhaCopiada(pilhaOriginal);

            Assert.Equal(1, pilhaCopiada.Pop());
            Assert.Equal(2, pilhaCopiada.Pop());
            Assert.Equal(3, pilhaCopiada.Pop());
            Assert.Equal(4, pilhaCopiada.Pop());
            Assert.Equal(5, pilhaCopiada.Pop());           
        }
    }
}
