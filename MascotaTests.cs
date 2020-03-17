using System;
using Xunit;

namespace MascotaVirtual.Tests
{
    public class MascotaTests
    {
        
        [Fact]
        public void PuedeComer_EstaLLeno_DevuelveFalso()
        {
            //Arrange
            Mascota mascota = new Mascota();
            mascota.EstaLleno = true;

            //Act
            var resultado = mascota.PuedeComer();

            //Assert
            Assert.False(resultado);

        }


    }
}
