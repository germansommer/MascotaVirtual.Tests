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
            mascota.EstaDespierto = true;

            //Act
            var resultado = mascota.PuedeComer();

            //Assert
            Assert.False(resultado);

        }

        [Fact]
        public void PuedeComer_NoEstaLLeno_DevuelveVerdadero()
        {
            //Arrange
            Mascota mascota = new Mascota();
            mascota.EstaLleno = false;
            mascota.EstaDespierto = true;

            //Act
            var resultado = mascota.PuedeComer();

            //Assert
            Assert.True(resultado);

        }

        [Fact]
        public void PuedeComer_EstaDormido_DevuelveFalso()
        {
            //Arrange
            Mascota mascota = new Mascota();
            mascota.EstaDespierto = false;

            //Act
            var resultado = mascota.PuedeComer();

            //Assert
            Assert.False(resultado);
        }

        [Fact]
        public void PuedeComer_EstaDespierto_DevuelveVerdadero()
        {
            //Arrange
            Mascota mascota = new Mascota();
            mascota.EstaDespierto = true;

            //Act
            var resultado = mascota.PuedeComer();

            //Assert
            Assert.True(resultado);
        }

        [Fact]
        public void PuedeDespertar_EstaDespierto_DevuelveFalso()
        {
            //Arrange
            Mascota mascota = new Mascota();
            mascota.EstaDespierto = true;

            //Act
            var resultado = mascota.PuedeDespertar();

            //Assert
            Assert.False(resultado);
        }
    }
}
